namespace LiH_Translation_Assistant
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dropPanel = new System.Windows.Forms.Panel();
            this.dropLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.radioButtonJson = new System.Windows.Forms.RadioButton();
            this.radioButtonTxt = new System.Windows.Forms.RadioButton();
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.dropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropPanel.Controls.Add(this.dropLabel);
            this.dropPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dropPanel.Location = new System.Drawing.Point(0, 0);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(113, 101);
            this.dropPanel.TabIndex = 0;
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            // 
            // dropLabel
            // 
            this.dropLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dropLabel.AutoSize = true;
            this.dropLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropLabel.Location = new System.Drawing.Point(19, 87);
            this.dropLabel.Name = "dropLabel";
            this.dropLabel.Size = new System.Drawing.Size(91, 13);
            this.dropLabel.TabIndex = 1;
            this.dropLabel.Tag = "0";
            this.dropLabel.Text = "Drop file here";
            // 
            // convertButton
            // 
            this.convertButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.convertButton.Enabled = false;
            this.convertButton.Location = new System.Drawing.Point(323, 0);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(83, 101);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // radioButtonJson
            // 
            this.radioButtonJson.AutoSize = true;
            this.radioButtonJson.Checked = true;
            this.radioButtonJson.Location = new System.Drawing.Point(119, 4);
            this.radioButtonJson.Name = "radioButtonJson";
            this.radioButtonJson.Size = new System.Drawing.Size(102, 17);
            this.radioButtonJson.TabIndex = 2;
            this.radioButtonJson.TabStop = true;
            this.radioButtonJson.Text = "From .txt to .json";
            this.radioButtonJson.UseVisualStyleBackColor = true;
            // 
            // radioButtonTxt
            // 
            this.radioButtonTxt.AutoSize = true;
            this.radioButtonTxt.Location = new System.Drawing.Point(222, 4);
            this.radioButtonTxt.Name = "radioButtonTxt";
            this.radioButtonTxt.Size = new System.Drawing.Size(102, 17);
            this.radioButtonTxt.TabIndex = 3;
            this.radioButtonTxt.Text = "From .json to .txt";
            this.radioButtonTxt.UseVisualStyleBackColor = true;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(116, 24);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(50, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Input file:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(119, 40);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(166, 20);
            this.inputTextBox.TabIndex = 6;
            this.inputTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(291, 40);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(26, 20);
            this.inputButton.TabIndex = 7;
            this.inputButton.Text = "...";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(291, 79);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(26, 20);
            this.outputButton.TabIndex = 10;
            this.outputButton.Text = "...";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(119, 79);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(166, 20);
            this.outputTextBox.TabIndex = 9;
            this.outputTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(116, 63);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(58, 13);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "Output file:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 101);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.radioButtonTxt);
            this.Controls.Add(this.radioButtonJson);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.dropPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiH-Translation-Assistant";
            this.dropPanel.ResumeLayout(false);
            this.dropPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dropPanel;
        private System.Windows.Forms.Label dropLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.RadioButton radioButtonJson;
        private System.Windows.Forms.RadioButton radioButtonTxt;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputLabel;
    }
}

