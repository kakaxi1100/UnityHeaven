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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(174, 19);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 21);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(174, 51);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 21);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sizeRadio);
            this.groupBox1.Controls.Add(this.countRadio);
            this.groupBox1.Location = new System.Drawing.Point(31, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // sizeRadio
            // 
            this.sizeRadio.AutoSize = true;
            this.sizeRadio.Checked = true;
            this.sizeRadio.Location = new System.Drawing.Point(133, 28);
            this.sizeRadio.Name = "sizeRadio";
            this.sizeRadio.Size = new System.Drawing.Size(65, 16);
            this.sizeRadio.TabIndex = 1;
            this.sizeRadio.TabStop = true;
            this.sizeRadio.Text = "By Size";
            this.sizeRadio.UseVisualStyleBackColor = true;
            this.sizeRadio.CheckedChanged += new System.EventHandler(this.sizeRadio_CheckedChanged);
            // 
            // countRadio
            // 
            this.countRadio.AutoSize = true;
            this.countRadio.Location = new System.Drawing.Point(6, 28);
            this.countRadio.Name = "countRadio";
            this.countRadio.Size = new System.Drawing.Size(71, 16);
            this.countRadio.TabIndex = 0;
            this.countRadio.Text = "By Count";
            this.countRadio.UseVisualStyleBackColor = true;
            this.countRadio.CheckedChanged += new System.EventHandler(this.countRadio_CheckedChanged);
            // 
            // valueTB
            // 
            this.valueTB.Location = new System.Drawing.Point(31, 156);
            this.valueTB.Name = "valueTB";
            this.valueTB.Size = new System.Drawing.Size(85, 21);
            this.valueTB.TabIndex = 5;
            this.valueTB.Text = "1";
            // 
            // filePB
            // 
            this.filePB.Location = new System.Drawing.Point(31, 218);
            this.filePB.Name = "filePB";
            this.filePB.Size = new System.Drawing.Size(218, 21);
            this.filePB.TabIndex = 7;
            // 
            // openFileTB
            // 
            this.openFileTB.Location = new System.Drawing.Point(31, 19);
            this.openFileTB.Name = "openFileTB";
            this.openFileTB.ReadOnly = true;
            this.openFileTB.Size = new System.Drawing.Size(137, 21);
            this.openFileTB.TabIndex = 8;
            // 
            // saveDirctTB
            // 
            this.saveDirctTB.Location = new System.Drawing.Point(31, 53);
            this.saveDirctTB.Name = "saveDirctTB";
            this.saveDirctTB.ReadOnly = true;
            this.saveDirctTB.Size = new System.Drawing.Size(137, 21);
            this.saveDirctTB.TabIndex = 9;
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
            this.unitCombo.Location = new System.Drawing.Point(128, 156);
            this.unitCombo.Name = "unitCombo";
            this.unitCombo.Size = new System.Drawing.Size(121, 20);
            this.unitCombo.TabIndex = 10;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(31, 183);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 21);
            this.startBtn.TabIndex = 11;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 256);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.unitCombo);
            this.Controls.Add(this.saveDirctTB);
            this.Controls.Add(this.openFileTB);
            this.Controls.Add(this.filePB);
            this.Controls.Add(this.valueTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(294, 294);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(294, 294);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

