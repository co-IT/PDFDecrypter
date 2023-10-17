namespace coIT.Tools.PDFDecrypter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenDirectory = new Button();
            chkOverwriteFiles = new CheckBox();
            ctrl_Files = new ListBox();
            btnDecrypt = new Button();
            openFileDialog1 = new OpenFileDialog();
            ctrl_SourceDirectory = new Label();
            ctrl_DecryptPassword = new TextBox();
            splitContainer1 = new SplitContainer();
            groupBox3 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            ctrl_DestinationDirectory = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenDirectory
            // 
            btnOpenDirectory.Location = new Point(6, 15);
            btnOpenDirectory.Name = "btnOpenDirectory";
            btnOpenDirectory.Size = new Size(123, 29);
            btnOpenDirectory.TabIndex = 0;
            btnOpenDirectory.Text = "Verzeichnis öffnen";
            btnOpenDirectory.UseVisualStyleBackColor = true;
            btnOpenDirectory.Click += btnOpenDirectory_Click;
            // 
            // chkOverwriteFiles
            // 
            chkOverwriteFiles.AutoSize = true;
            chkOverwriteFiles.Checked = true;
            chkOverwriteFiles.CheckState = CheckState.Checked;
            chkOverwriteFiles.Location = new Point(18, 31);
            chkOverwriteFiles.Name = "chkOverwriteFiles";
            chkOverwriteFiles.Size = new Size(36, 19);
            chkOverwriteFiles.TabIndex = 1;
            chkOverwriteFiles.Text = "Ja";
            chkOverwriteFiles.UseVisualStyleBackColor = true;
            chkOverwriteFiles.CheckedChanged += chkOverwriteFiles_CheckedChanged;
            // 
            // ctrl_Files
            // 
            ctrl_Files.Dock = DockStyle.Fill;
            ctrl_Files.FormattingEnabled = true;
            ctrl_Files.ItemHeight = 15;
            ctrl_Files.Location = new Point(0, 0);
            ctrl_Files.Name = "ctrl_Files";
            ctrl_Files.Size = new Size(1008, 560);
            ctrl_Files.TabIndex = 2;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.Lime;
            btnDecrypt.Location = new Point(873, 90);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(123, 72);
            btnDecrypt.TabIndex = 3;
            btnDecrypt.Text = "Entschlüsseln";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ctrl_SourceDirectory
            // 
            ctrl_SourceDirectory.AutoSize = true;
            ctrl_SourceDirectory.Location = new Point(135, 22);
            ctrl_SourceDirectory.Name = "ctrl_SourceDirectory";
            ctrl_SourceDirectory.Size = new Size(0, 15);
            ctrl_SourceDirectory.TabIndex = 4;
            ctrl_SourceDirectory.Visible = false;
            // 
            // ctrl_DecryptPassword
            // 
            ctrl_DecryptPassword.Location = new Point(166, 31);
            ctrl_DecryptPassword.Name = "ctrl_DecryptPassword";
            ctrl_DecryptPassword.Size = new Size(168, 23);
            ctrl_DecryptPassword.TabIndex = 5;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(btnDecrypt);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listBox1);
            splitContainer1.Panel2.Controls.Add(ctrl_Files);
            splitContainer1.Size = new Size(1008, 729);
            splitContainer1.SplitterDistance = 165;
            splitContainer1.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ctrl_DecryptPassword);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(425, 80);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Entschlüsselung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 6;
            label1.Text = "Passwort zum Entschlüsseln";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpenDirectory);
            groupBox2.Controls.Add(ctrl_SourceDirectory);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(984, 51);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quelle";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(627, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ctrl_DestinationDirectory);
            groupBox1.Controls.Add(chkOverwriteFiles);
            groupBox1.Location = new Point(443, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 80);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Verschlüsselte Dateien überschreiben";
            // 
            // ctrl_DestinationDirectory
            // 
            ctrl_DestinationDirectory.AutoSize = true;
            ctrl_DestinationDirectory.Location = new Point(16, 53);
            ctrl_DestinationDirectory.Name = "ctrl_DestinationDirectory";
            ctrl_DestinationDirectory.Size = new Size(0, 15);
            ctrl_DestinationDirectory.TabIndex = 2;
            ctrl_DestinationDirectory.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            MaximumSize = new Size(1024, 768);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDFs entschlüsseln";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenDirectory;
        private CheckBox chkOverwriteFiles;
        private ListBox ctrl_Files;
        private Button btnDecrypt;
        private OpenFileDialog openFileDialog1;
        private Label ctrl_SourceDirectory;
        private TextBox ctrl_DecryptPassword;
        private SplitContainer splitContainer1;
        private GroupBox groupBox3;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label ctrl_DestinationDirectory;
        private ListBox listBox1;
    }
}