using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Tool_Sphere
{
    public partial class Folder_Split_TXT_Files : Form
    {
        public Folder_Split_TXT_Files()
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

        private async void btnStartSplitProcess_Click(object sender, EventArgs e)
        {
            btnChoosePath.Enabled = false;
            btnStartSplitProcess.Enabled = false;

            string directoryPath = textBoxPath.Text;
            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("Please select a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maxFileSizeMB;
            if (!int.TryParse(numericFileMaxSize.Value.ToString(), out maxFileSizeMB) || maxFileSizeMB <= 0)
            {
                MessageBox.Show("Please enter a valid file size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long maxFileSize = maxFileSizeMB * 1024L * 1024L;
            string outputDirectory = Path.Combine(directoryPath, "SplitFiles");
            Directory.CreateDirectory(outputDirectory);

            await Task.Run(() => SplitFiles(directoryPath, outputDirectory, maxFileSize));

            MessageBox.Show("Splitting process completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnChoosePath.Enabled = true;
            btnStartSplitProcess.Enabled = true;
        }
        private void SplitFiles(string directoryPath, string outputDirectory, long maxFileSize)
        {
            string[] txtFiles = Directory.GetFiles(directoryPath, "*.txt");

            if (txtFiles.Length == 0)
            {
                listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add("⚠️ No TXT files found in the directory."); });
                return;
            }

            listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add($"📂 {txtFiles.Length} TXT files found. Starting split process..."); });

            foreach (string filePath in txtFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                int partNumber = 1;
                long currentFileSize = 0;
                StringBuilder partContent = new StringBuilder();

                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        byte[] lineBytes = Encoding.UTF8.GetBytes(line + Environment.NewLine);

                        if (currentFileSize + lineBytes.Length > maxFileSize)
                        {
                            WritePartToFile(outputDirectory, fileName, partNumber, partContent);
                            partNumber++;
                            currentFileSize = 0;
                            partContent.Clear();
                        }

                        partContent.AppendLine(line);
                        currentFileSize += lineBytes.Length;
                    }

                    if (partContent.Length > 0)
                    {
                        WritePartToFile(outputDirectory, fileName, partNumber, partContent);
                    }
                }

                if (checkBoxDeleteOriginalFile.Checked)
                {
                    try
                    {
                        File.Delete(filePath);
                        listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add($"🗑️ Deleted original file: {Path.GetFileName(filePath)}"); });
                    }
                    catch (Exception ex)
                    {
                        listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add($"⚠️ Error deleting {Path.GetFileName(filePath)}: {ex.Message}"); });
                    }
                }
            }

            listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add("✅ Splitting process completed!"); });
        }

        private void WritePartToFile(string outputDirectory, string originalFileName, int partNumber, StringBuilder content)
        {
            string partFileName = Path.Combine(outputDirectory, $"{originalFileName}_SplitPart[{partNumber}].txt");
            File.WriteAllText(partFileName, content.ToString());
            listBoxProcessDetails.Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add($"📄 Created: {Path.GetFileName(partFileName)}"); });
        }
    }
}
