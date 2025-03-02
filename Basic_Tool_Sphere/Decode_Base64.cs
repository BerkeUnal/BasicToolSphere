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
    public partial class Decode_Base64 : Form
    {
        public Decode_Base64()
        {
            InitializeComponent();
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Select a TXT file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog.FileName;
                LoadFilePreview(openFileDialog.FileName);
            }
        }
        private void LoadFilePreview(string filePath)
        {
            try
            {
                string[] lines = File.ReadLines(filePath).Take(100).ToArray();
                listBoxTXTrows.Items.Clear();
                listBoxTXTrows.Items.AddRange(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file:\n" + ex.Message, "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartFileProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilePath.Text) || !File.Exists(textBoxFilePath.Text))
            {
                MessageBox.Show("Please select a valid TXT file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = textBoxFilePath.Text;
            string newFilePath = Path.Combine(Path.GetDirectoryName(filePath),
                                  radioButtonFileDecode.Checked ? "decoded_base64_output.txt" : "encoded_base64_output.txt");

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                using (StreamWriter writer = new StreamWriter(newFilePath, false, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string processedLine = radioButtonFileDecode.Checked ? DecodeBase64(line) : EncodeBase64(line);
                        writer.WriteLine(processedLine);
                    }
                }

                MessageBox.Show("Process completed successfully.\n\nOutput file:\n" + newFilePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the file:\n" + ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonManuallyDecode.Checked)
                richTextBoxOutput.Text = DecodeBase64(richTextBoxInput.Text);
            else if (radioButtonManuallyEncode.Checked)
                richTextBoxOutput.Text = EncodeBase64(richTextBoxInput.Text);
        }

        private void radioButtonFileEncode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFileDecode.Checked)
                btnStartFileProcess.Text = "Start Decode Process";
            else
                btnStartFileProcess.Text = "Start Encode Process";
        }

        private string EncodeBase64(string input)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                return Convert.ToBase64String(bytes);
            }
            catch
            {
                return "Encoding Error!";
            }
        }

        public static string DecodeBase64(string base64Data)
        {
            try
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(base64Data));
            }
            catch
            {
                try
                {
                    return Encoding.UTF8.GetString(Convert.FromBase64String(base64Data + "="));
                }
                catch
                {
                    try
                    {
                        return Encoding.UTF8.GetString(Convert.FromBase64String(base64Data + "=="));
                    }
                    catch
                    {
                        return "Invalid Base64 Data";
                    }
                }
            }
        }

        private void radioButtonManuallyDecode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonManuallyDecode.Checked)
                richTextBoxOutput.Text = DecodeBase64(richTextBoxInput.Text);
            else if (radioButtonManuallyEncode.Checked)
                richTextBoxOutput.Text = EncodeBase64(richTextBoxInput.Text);
        }
    }
}
