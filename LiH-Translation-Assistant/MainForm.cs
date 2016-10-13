using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LiH_Translation_Assistant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string inputTextBoxText
        {
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    return;
                }
                inputTextBox.Text = value;
                string ext = radioButtonJson.Checked ? "json" : "txt";
                outputTextBox.Text = $"{Path.GetDirectoryName(value)}\\{Path.GetFileNameWithoutExtension(value)}.{ext}";
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            convertButton.Enabled = !string.IsNullOrWhiteSpace(inputTextBox.Text) &&
                                    !string.IsNullOrWhiteSpace(outputTextBox.Text);
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() {
                Multiselect = false,
                Filter = radioButtonJson.Checked ? "Text file (*.txt)|*.txt" : "Json file (*.json)|*.json"
            };
            dialog.ShowDialog();
            inputTextBoxText = dialog.FileName;
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog() {
                OverwritePrompt = true,
                Filter = radioButtonJson.Checked ? "Json file (*.json)|*.json" : "Text file (*.txt)|*.txt"
            };
            dialog.ShowDialog();
            outputTextBox.Text = dialog.FileName;
        }

        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            Console.WriteLine(new FileInfo(file[0]).Extension);
            switch (new FileInfo(file[0]).Extension) {
                case ".json":
                    radioButtonTxt.Checked = true;
                    break;
                case ".txt":
                    radioButtonJson.Checked = true;
                    break;
                default:
                    return;
            }
            inputTextBoxText = file[0];
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (radioButtonJson.Checked) {
                ConvertTxt();
            } else {
                ConvertJson();
            }
            MessageBox.Show("Done!", "Done", MessageBoxButtons.OK);
        }

        private void ConvertJson()
        {
            JObject json = JObject.Parse(File.ReadAllText(inputTextBox.Text));
            string convertedText = null;
            foreach (var jt in json) {
                convertedText += $"\"{jt.Key}\" | \"{jt.Value}\";\n";
            }
            File.WriteAllText(outputTextBox.Text, convertedText);
        }

        private void ConvertTxt()
        {
            Regex rgx = new Regex("\"(.+)\" \\| \"(.+)\"", RegexOptions.IgnoreCase);
            JObject json = new JObject();
            foreach (Match m in rgx.Matches(File.ReadAllText(inputTextBox.Text))) {
                json.Add(new JProperty(m.Groups[1].Value, m.Groups[2].Value));
            }
            File.WriteAllText(outputTextBox.Text, json.ToString());
        }
    }
}
