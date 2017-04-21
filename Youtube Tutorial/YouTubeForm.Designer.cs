namespace Youtube_Tutorial
{
    partial class YouTubeForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTubeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTextField = new System.Windows.Forms.TextBox();
            this.printMessageButton = new System.Windows.Forms.Button();
            this.printTextButton = new System.Windows.Forms.Button();
            this.printedText = new System.Windows.Forms.Label();
            this.basicCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.favoriteIPhoneCombo = new System.Windows.Forms.ComboBox();
            this.checkMyCheckboxButton = new System.Windows.Forms.Button();
            this.submitComboBoxButton = new System.Windows.Forms.Button();
            this.amIHappyRadioButton1 = new System.Windows.Forms.RadioButton();
            this.amIHappyRadioButton2 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisSoftwareToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutThisSoftwareToolStripMenuItem
            // 
            this.aboutThisSoftwareToolStripMenuItem.Name = "aboutThisSoftwareToolStripMenuItem";
            this.aboutThisSoftwareToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutThisSoftwareToolStripMenuItem.Text = "About This Software";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusLabel1.Text = "YouTube Tutorial Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Text:";
            // 
            // outputTextField
            // 
            this.outputTextField.ContextMenuStrip = this.contextMenuStrip1;
            this.outputTextField.Location = new System.Drawing.Point(105, 77);
            this.outputTextField.Name = "outputTextField";
            this.outputTextField.Size = new System.Drawing.Size(469, 20);
            this.outputTextField.TabIndex = 4;
            // 
            // printMessageButton
            // 
            this.printMessageButton.Location = new System.Drawing.Point(105, 105);
            this.printMessageButton.Name = "printMessageButton";
            this.printMessageButton.Size = new System.Drawing.Size(172, 44);
            this.printMessageButton.TabIndex = 5;
            this.printMessageButton.Text = "Print to Message";
            this.printMessageButton.UseVisualStyleBackColor = true;
            this.printMessageButton.Click += new System.EventHandler(this.printMessageButton_Click);
            // 
            // printTextButton
            // 
            this.printTextButton.Location = new System.Drawing.Point(402, 105);
            this.printTextButton.Name = "printTextButton";
            this.printTextButton.Size = new System.Drawing.Size(172, 44);
            this.printTextButton.TabIndex = 6;
            this.printTextButton.Text = "Print Text";
            this.printTextButton.UseVisualStyleBackColor = true;
            this.printTextButton.Click += new System.EventHandler(this.printTextButton_Click);
            // 
            // printedText
            // 
            this.printedText.AutoSize = true;
            this.printedText.Location = new System.Drawing.Point(93, 136);
            this.printedText.Name = "printedText";
            this.printedText.Size = new System.Drawing.Size(0, 13);
            this.printedText.TabIndex = 7;
            this.printedText.Visible = false;
            // 
            // basicCheckbox
            // 
            this.basicCheckbox.AutoSize = true;
            this.basicCheckbox.Location = new System.Drawing.Point(27, 178);
            this.basicCheckbox.Name = "basicCheckbox";
            this.basicCheckbox.Size = new System.Drawing.Size(149, 17);
            this.basicCheckbox.TabIndex = 8;
            this.basicCheckbox.Text = "Check me to see if I work!";
            this.basicCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amIHappyRadioButton2);
            this.groupBox1.Controls.Add(this.amIHappyRadioButton1);
            this.groupBox1.Controls.Add(this.printedText);
            this.groupBox1.Controls.Add(this.submitComboBoxButton);
            this.groupBox1.Controls.Add(this.basicCheckbox);
            this.groupBox1.Controls.Add(this.checkMyCheckboxButton);
            this.groupBox1.Controls.Add(this.favoriteIPhoneCombo);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 400);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YouTube Form Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // favoriteIPhoneCombo
            // 
            this.favoriteIPhoneCombo.FormattingEnabled = true;
            this.favoriteIPhoneCombo.Items.AddRange(new object[] {
            "Apple iPhone 5",
            "Apple iPhone 5s",
            "Apple iPhone 6",
            "Apple iPhone 6s",
            "Apple iPhone 7",
            "Apple iPhone 7s"});
            this.favoriteIPhoneCombo.Location = new System.Drawing.Point(389, 176);
            this.favoriteIPhoneCombo.Name = "favoriteIPhoneCombo";
            this.favoriteIPhoneCombo.Size = new System.Drawing.Size(172, 21);
            this.favoriteIPhoneCombo.TabIndex = 0;
            this.favoriteIPhoneCombo.Text = "What is your favorite iPhone?";
            this.favoriteIPhoneCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkMyCheckboxButton
            // 
            this.checkMyCheckboxButton.Location = new System.Drawing.Point(23, 200);
            this.checkMyCheckboxButton.Name = "checkMyCheckboxButton";
            this.checkMyCheckboxButton.Size = new System.Drawing.Size(149, 36);
            this.checkMyCheckboxButton.TabIndex = 12;
            this.checkMyCheckboxButton.Text = "Check My Checkbox!";
            this.checkMyCheckboxButton.UseVisualStyleBackColor = true;
            this.checkMyCheckboxButton.Click += new System.EventHandler(this.checkMyCheckboxButton_Click);
            // 
            // submitComboBoxButton
            // 
            this.submitComboBoxButton.Location = new System.Drawing.Point(412, 200);
            this.submitComboBoxButton.Name = "submitComboBoxButton";
            this.submitComboBoxButton.Size = new System.Drawing.Size(149, 36);
            this.submitComboBoxButton.TabIndex = 13;
            this.submitComboBoxButton.Text = "Submit";
            this.submitComboBoxButton.UseVisualStyleBackColor = true;
            this.submitComboBoxButton.Click += new System.EventHandler(this.submitComboBoxButton_Click);
            // 
            // amIHappyRadioButton1
            // 
            this.amIHappyRadioButton1.AutoSize = true;
            this.amIHappyRadioButton1.Location = new System.Drawing.Point(27, 251);
            this.amIHappyRadioButton1.Name = "amIHappyRadioButton1";
            this.amIHappyRadioButton1.Size = new System.Drawing.Size(237, 17);
            this.amIHappyRadioButton1.TabIndex = 14;
            this.amIHappyRadioButton1.TabStop = true;
            this.amIHappyRadioButton1.Text = "I am happy with this application I have made!";
            this.amIHappyRadioButton1.UseVisualStyleBackColor = true;
            this.amIHappyRadioButton1.CheckedChanged += new System.EventHandler(this.amIHappyRadioButton1_CheckedChanged);
            // 
            // amIHappyRadioButton2
            // 
            this.amIHappyRadioButton2.AutoSize = true;
            this.amIHappyRadioButton2.Location = new System.Drawing.Point(27, 275);
            this.amIHappyRadioButton2.Name = "amIHappyRadioButton2";
            this.amIHappyRadioButton2.Size = new System.Drawing.Size(208, 17);
            this.amIHappyRadioButton2.TabIndex = 15;
            this.amIHappyRadioButton2.TabStop = true;
            this.amIHappyRadioButton2.Text = "No, I\'m not happy with what I\'ve made!";
            this.amIHappyRadioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(640, 452);
            this.Controls.Add(this.printMessageButton);
            this.Controls.Add(this.printTextButton);
            this.Controls.Add(this.outputTextField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Tutorial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisSoftwareToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputTextField;
        private System.Windows.Forms.Button printMessageButton;
        private System.Windows.Forms.Button printTextButton;
        private System.Windows.Forms.Label printedText;
        private System.Windows.Forms.CheckBox basicCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox favoriteIPhoneCombo;
        private System.Windows.Forms.Button checkMyCheckboxButton;
        private System.Windows.Forms.Button submitComboBoxButton;
        private System.Windows.Forms.RadioButton amIHappyRadioButton2;
        private System.Windows.Forms.RadioButton amIHappyRadioButton1;
    }
}

