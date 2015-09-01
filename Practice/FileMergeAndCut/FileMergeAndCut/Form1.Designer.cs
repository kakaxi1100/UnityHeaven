namespace FileMergeAndCut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sizeRadio = new System.Windows.Forms.RadioButton();
            this.countRadio = new System.Windows.Forms.RadioButton();
            this.valueTB = new System.Windows.Forms.TextBox();
            this.filePB = new System.Windows.Forms.ProgressBar();
            this.openFileTB = new System.Windows.Forms.TextBox();
            this.saveDirctTB = new System.Windows.Forms.TextBox();
            this.unitCombo = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.cutPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mergeRadio = new System.Windows.Forms.RadioButton();
            this.cutRadio = new System.Windows.Forms.RadioButton();
            this.mergePanel = new System.Windows.Forms.Panel();
            this.mergePB = new System.Windows.Forms.ProgressBar();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.mergeFileList = new System.Windows.Forms.ListBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.selectTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.cutPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mergePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(156, 12);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(156, 46);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sizeRadio);
            this.groupBox1.Controls.Add(this.countRadio);
            this.groupBox1.Location = new System.Drawing.Point(13, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // sizeRadio
            // 
            this.sizeRadio.AutoSize = true;
            this.sizeRadio.Checked = true;
            this.sizeRadio.Location = new System.Drawing.Point(133, 30);
            this.sizeRadio.Name = "sizeRadio";
            this.sizeRadio.Size = new System.Drawing.Size(60, 17);
            this.sizeRadio.TabIndex = 1;
            this.sizeRadio.TabStop = true;
            this.sizeRadio.Text = "By Size";
            this.sizeRadio.UseVisualStyleBackColor = true;
            this.sizeRadio.CheckedChanged += new System.EventHandler(this.sizeRadio_CheckedChanged);
            // 
            // countRadio
            // 
            this.countRadio.AutoSize = true;
            this.countRadio.Location = new System.Drawing.Point(6, 30);
            this.countRadio.Name = "countRadio";
            this.countRadio.Size = new System.Drawing.Size(68, 17);
            this.countRadio.TabIndex = 0;
            this.countRadio.Text = "By Count";
            this.countRadio.UseVisualStyleBackColor = true;
            this.countRadio.CheckedChanged += new System.EventHandler(this.countRadio_CheckedChanged);
            // 
            // valueTB
            // 
            this.valueTB.Location = new System.Drawing.Point(13, 160);
            this.valueTB.Name = "valueTB";
            this.valueTB.Size = new System.Drawing.Size(85, 20);
            this.valueTB.TabIndex = 5;
            this.valueTB.Text = "1";
            this.valueTB.TextChanged += new System.EventHandler(this.valueTB_TextChanged);
            // 
            // filePB
            // 
            this.filePB.Location = new System.Drawing.Point(13, 227);
            this.filePB.Name = "filePB";
            this.filePB.Size = new System.Drawing.Size(218, 23);
            this.filePB.TabIndex = 7;
            // 
            // openFileTB
            // 
            this.openFileTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileTB.Location = new System.Drawing.Point(13, 12);
            this.openFileTB.Name = "openFileTB";
            this.openFileTB.ReadOnly = true;
            this.openFileTB.Size = new System.Drawing.Size(137, 20);
            this.openFileTB.TabIndex = 8;
            this.openFileTB.Click += new System.EventHandler(this.openFileTB_Click);
            // 
            // saveDirctTB
            // 
            this.saveDirctTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveDirctTB.Location = new System.Drawing.Point(13, 48);
            this.saveDirctTB.Name = "saveDirctTB";
            this.saveDirctTB.ReadOnly = true;
            this.saveDirctTB.Size = new System.Drawing.Size(137, 20);
            this.saveDirctTB.TabIndex = 9;
            this.saveDirctTB.Click += new System.EventHandler(this.saveDirctTB_Click);
            // 
            // unitCombo
            // 
            this.unitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitCombo.FormattingEnabled = true;
            this.unitCombo.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB"});
            this.unitCombo.Location = new System.Drawing.Point(110, 160);
            this.unitCombo.Name = "unitCombo";
            this.unitCombo.Size = new System.Drawing.Size(121, 21);
            this.unitCombo.TabIndex = 10;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(13, 189);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // cutPanel
            // 
            this.cutPanel.Controls.Add(this.openFileTB);
            this.cutPanel.Controls.Add(this.startBtn);
            this.cutPanel.Controls.Add(this.openBtn);
            this.cutPanel.Controls.Add(this.unitCombo);
            this.cutPanel.Controls.Add(this.saveBtn);
            this.cutPanel.Controls.Add(this.saveDirctTB);
            this.cutPanel.Controls.Add(this.groupBox1);
            this.cutPanel.Controls.Add(this.valueTB);
            this.cutPanel.Controls.Add(this.filePB);
            this.cutPanel.Location = new System.Drawing.Point(12, 49);
            this.cutPanel.Name = "cutPanel";
            this.cutPanel.Size = new System.Drawing.Size(241, 264);
            this.cutPanel.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mergeRadio);
            this.groupBox2.Controls.Add(this.cutRadio);
            this.groupBox2.Location = new System.Drawing.Point(25, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 34);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // mergeRadio
            // 
            this.mergeRadio.AutoSize = true;
            this.mergeRadio.Location = new System.Drawing.Point(133, 11);
            this.mergeRadio.Name = "mergeRadio";
            this.mergeRadio.Size = new System.Drawing.Size(55, 17);
            this.mergeRadio.TabIndex = 1;
            this.mergeRadio.Text = "Merge";
            this.mergeRadio.UseVisualStyleBackColor = true;
            this.mergeRadio.CheckedChanged += new System.EventHandler(this.mergeRadio_CheckedChanged);
            // 
            // cutRadio
            // 
            this.cutRadio.AutoSize = true;
            this.cutRadio.Checked = true;
            this.cutRadio.Location = new System.Drawing.Point(6, 11);
            this.cutRadio.Name = "cutRadio";
            this.cutRadio.Size = new System.Drawing.Size(41, 17);
            this.cutRadio.TabIndex = 0;
            this.cutRadio.TabStop = true;
            this.cutRadio.Text = "Cut";
            this.cutRadio.UseVisualStyleBackColor = true;
            this.cutRadio.CheckedChanged += new System.EventHandler(this.cutRadio_CheckedChanged);
            // 
            // mergePanel
            // 
            this.mergePanel.Controls.Add(this.mergePB);
            this.mergePanel.Controls.Add(this.mergeBtn);
            this.mergePanel.Controls.Add(this.mergeFileList);
            this.mergePanel.Controls.Add(this.selectBtn);
            this.mergePanel.Controls.Add(this.selectTB);
            this.mergePanel.Location = new System.Drawing.Point(12, 49);
            this.mergePanel.Name = "mergePanel";
            this.mergePanel.Size = new System.Drawing.Size(241, 264);
            this.mergePanel.TabIndex = 14;
            // 
            // mergePB
            // 
            this.mergePB.Location = new System.Drawing.Point(12, 227);
            this.mergePB.Name = "mergePB";
            this.mergePB.Size = new System.Drawing.Size(218, 23);
            this.mergePB.TabIndex = 4;
            // 
            // mergeBtn
            // 
            this.mergeBtn.Location = new System.Drawing.Point(12, 189);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(75, 23);
            this.mergeBtn.TabIndex = 3;
            this.mergeBtn.Text = "Merge";
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // mergeFileList
            // 
            this.mergeFileList.FormattingEnabled = true;
            this.mergeFileList.Location = new System.Drawing.Point(12, 48);
            this.mergeFileList.Name = "mergeFileList";
            this.mergeFileList.Size = new System.Drawing.Size(218, 134);
            this.mergeFileList.TabIndex = 2;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(155, 12);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // selectTB
            // 
            this.selectTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectTB.Location = new System.Drawing.Point(12, 14);
            this.selectTB.Name = "selectTB";
            this.selectTB.ReadOnly = true;
            this.selectTB.Size = new System.Drawing.Size(137, 20);
            this.selectTB.TabIndex = 0;
            this.selectTB.Click += new System.EventHandler(this.selectTB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 319);
            this.Controls.Add(this.mergePanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(282, 357);
            this.MinimumSize = new System.Drawing.Size(282, 357);
            this.Name = "Form1";
            this.Text = "Broken Magnet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cutPanel.ResumeLayout(false);
            this.cutPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mergePanel.ResumeLayout(false);
            this.mergePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sizeRadio;
        private System.Windows.Forms.RadioButton countRadio;
        private System.Windows.Forms.TextBox valueTB;
        private System.Windows.Forms.ProgressBar filePB;
        private System.Windows.Forms.TextBox openFileTB;
        private System.Windows.Forms.TextBox saveDirctTB;
        private System.Windows.Forms.ComboBox unitCombo;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel cutPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton mergeRadio;
        private System.Windows.Forms.RadioButton cutRadio;
        private System.Windows.Forms.Panel mergePanel;
        private System.Windows.Forms.ProgressBar mergePB;
        private System.Windows.Forms.Button mergeBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox selectTB;
        private System.Windows.Forms.ListBox mergeFileList;
    }
}

