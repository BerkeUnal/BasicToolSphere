using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osint_Tool
{
    public partial class Folder_TXT_Duplicate_Cleaner : Form
    {
        public Folder_TXT_Duplicate_Cleaner()
        {
            InitializeComponent();
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = fbd.SelectedPath;
                    ListTxtFiles(fbd.SelectedPath);
                }
            }
        }

        private void ListTxtFiles(string directoryPath)
        {
            listBoxTXTFiles.Items.Clear();
            listBoxProcessDetails.Items.Clear();
            string[] txtFiles = Directory.GetFiles(directoryPath, "*.txt");
            foreach (string file in txtFiles)
            {
                listBoxTXTFiles.Items.Add(Path.GetFileName(file));
            }
            listBoxProcessDetails.Items.Add($"📂 {txtFiles.Length} .txt files found.");
        }

        private async void btnRemoveDuplicateLines_Click(object sender, EventArgs e)
        {
            string directoryPath = textBoxPath.Text;
            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("⚠️ Please select a valid directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string logDirectory = Path.Combine(Application.StartupPath, "DirectoryTXTDuplicateCleanLog");
            Directory.CreateDirectory(logDirectory);
            string logFilePath = Path.Combine(logDirectory, $"{DateTime.Now:dd.MM.yyyy_HH.mm.ss}_islem_log.txt");

            listBoxProcessDetails.Items.Add($"⏳ Process Start Time: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            File.AppendAllText(logFilePath, $"Process Start Time: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n");

            string[] txtFiles = Directory.GetFiles(directoryPath, "*.txt");
            await Task.Run(() => ProcessFiles(txtFiles, logFilePath));

            listBoxProcessDetails.Items.Add($"✅ Process Completed: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            File.AppendAllText(logFilePath, $"Process Completed: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n");
            MessageBox.Show("✔️ Process successfully completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int removedLines = 0;
        private void ProcessFiles(string[] txtFiles, string logFilePath)
        {
            foreach (string filePath in txtFiles)
            {
                Invoke((MethodInvoker)delegate { listBoxProcessDetails.Items.Add($"🔍 Processing: {Path.GetFileName(filePath)}"); });

                int originalLineCount = File.ReadLines(filePath).Count();
                int uniqueLineCount = ProcessFile(filePath, logFilePath);

                File.Delete(filePath);

                removedLines = originalLineCount - uniqueLineCount;
                Invoke((MethodInvoker)delegate
                {
                    listBoxProcessDetails.Items.Add($"✅ Processed: {removedLines} lines removed");
                    listBoxProcessDetails.Items.Add($"🗑️ Deleted: {Path.GetFileName(filePath)}");
                });
            }
        }

        private int ProcessFile(string inputFilePath, string logFilePath)
        {
            HashSet<string> uniqueLines = new HashSet<string>();
            string outputFilePath = inputFilePath.Replace(".txt", "_unique.txt");

            using (StreamReader reader = new StreamReader(inputFilePath, Encoding.UTF8))
            using (StreamWriter writer = new StreamWriter(outputFilePath, false, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (uniqueLines.Add(line))
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            File.AppendAllText(logFilePath, $"Processed: {Path.GetFileName(inputFilePath)} - {removedLines} lines removed\n");
            return uniqueLines.Count;
        }
    }
}
