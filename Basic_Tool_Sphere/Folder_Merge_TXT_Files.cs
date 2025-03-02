using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osint_Tool
{
    public partial class Folder_Merge_TXT_Files : Form
    {
        public Folder_Merge_TXT_Files()
        {
            InitializeComponent();
        }
        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = dialog.SelectedPath;
                    listBoxTXTFiles.Items.Clear();
                    listBoxProcessDetails.Items.Clear();

                    string directoryPath = textBoxPath.Text;
                    if (Directory.Exists(directoryPath))
                    {
                        string[] txtFiles = Directory.GetFiles(directoryPath, "*.txt");
                        foreach (string file in txtFiles)
                        {
                            listBoxTXTFiles.Items.Add(Path.GetFileName(file));
                        }
                        listBoxProcessDetails.Items.Add($"📂 {txtFiles.Length} TXT files found.");
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private async void btnStartMergeProcess_Click(object sender, EventArgs e)
        {
            btnChoosePath.Enabled = false;
            btnStartMergeProcess.Enabled = false;
            string directoryPath = textBoxPath.Text;
            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("Please select a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string outputFileName = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(outputFileName))
            {
                MessageBox.Show("Please enter a file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maxFileSizeMB;
            if (!int.TryParse(numericFileMaxSize.Value.ToString(), out maxFileSizeMB) || maxFileSizeMB <= 0)
            {
                MessageBox.Show("Please enter a valid file size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long maxFileSize = maxFileSizeMB * 1024L * 1024L;
            string outputDirectory = Path.Combine(directoryPath, "MergedFiles");
            Directory.CreateDirectory(outputDirectory);

            await Task.Run(() => MergeFiles(directoryPath, outputDirectory, outputFileName, maxFileSize));

            MessageBox.Show("Merging process completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnChoosePath.Enabled = true;
            btnStartMergeProcess.Enabled = true;
        }
        private void MergeFiles(string directoryPath, string outputDirectory, string baseFileName, long maxFileSize)
        {
            // Sorting files from largest to smallest
            string[] txtFiles = Directory.GetFiles(directoryPath, "*.txt").OrderByDescending(f => new FileInfo(f).Length).ToArray();

            if (txtFiles.Length == 0) return;
            int partNumber = 1;
            long currentFileSize = 0;
            StreamWriter writer = CreateNewWriter(outputDirectory, baseFileName, ref partNumber);
            string startTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add($"🛠️ Merging process started - {startTime}"); });

            foreach (string filePath in txtFiles)
            {
                listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add($"📄 Processing {Path.GetFileName(filePath)}..."); });

                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        byte[] lineBytes = Encoding.UTF8.GetBytes(line + Environment.NewLine);
                        currentFileSize += lineBytes.Length;

                        if (currentFileSize >= maxFileSize)
                        {
                            writer.Close();
                            writer = CreateNewWriter(outputDirectory, baseFileName, ref partNumber);
                            currentFileSize = lineBytes.Length;
                        }
                        writer.WriteLine(line);
                    }
                }

                if (checkBoxDeleteOriginalFile.Checked)
                {
                    if (File.Exists(filePath) && Path.GetExtension(filePath).ToLower() == ".txt")
                        File.Delete(filePath);
                    else
                        listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add("⚠️ An error occurred while deleting the original files."); });
                }
            }
            writer.Close();
            string endTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add($"✅ Process completed - {endTime}"); });
            MessageBox.Show("✅ Merging process completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private StreamWriter CreateNewWriter(string outputDirectory, string baseFileName, ref int partNumber)
        {
            string datePrefix = DateTime.Now.ToString("dd.MM.yyyy");
            string outputFilePath = Path.Combine(outputDirectory, $"{datePrefix} - {baseFileName}_part({partNumber}).txt");
            partNumber++;
            return new StreamWriter(outputFilePath, false, Encoding.UTF8);
        }
    }
}
