using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LiH_Translation_Assistant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string InputTextBoxText
        {
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    return;
                }
                inputTextBox.Text = value;
                string ext = radioButtonJson.Checked ? "json" : "txt";
                outputTextBox.Text = $@"{Path.GetDirectoryName(value)}\{Path.GetFileNameWithoutExtension(value)}.{ext}";
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
            InputTextBoxText = dialog.FileName;
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
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) {
                return;
            }
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            switch (new FileInfo(file[0]).Extension) {
                case ".json":
                case ".txt":
                    e.Effect = DragDropEffects.Copy;
                    return;
                default:
                    e.Effect = DragDropEffects.None;
                    return;
            }
        }

        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
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
            Activate();
            InputTextBoxText = file[0];
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int totalStrings = 0;
            if (radioButtonJson.Checked) {
                ConvertTxt(ref totalStrings);
            } else {
                ConvertJson(out totalStrings);
            }
            MessageBox.Show($"Done!\nProcessed strings: {totalStrings}", "Done", MessageBoxButtons.OK);
        }

        private void ConvertJson(out int totalStrings)
        {
            Dictionary<string, string> dic =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(inputTextBox.Text));
            totalStrings = dic.Count;
            string convertedText = string.Join(";\n", dic.Select(prop => $"\"{prop.Key}\" | \"{prop.Value}\""));
            File.WriteAllText(outputTextBox.Text, convertedText);
        }

        private void ConvertTxt(ref int totalStrings)
        {
            Regex rgx = new Regex("\"(.+)\" \\| \"(.+)\"", RegexOptions.IgnoreCase);
            JObject json = new JObject();
            foreach (Match m in rgx.Matches(File.ReadAllText(inputTextBox.Text))) {
                if (json[m.Groups[1].Value] != null) {
                    continue;
                }
                totalStrings++;
                json.Add(new JProperty(m.Groups[1].Value, m.Groups[2].Value));
            }
            File.WriteAllText(outputTextBox.Text, json.ToString());
        }
    }
}
