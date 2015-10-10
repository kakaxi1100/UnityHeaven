namespace AudioTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.asterisk = new System.Windows.Forms.Button();
            this.launch1 = new System.Windows.Forms.Button();
            this.beep = new System.Windows.Forms.Button();
            this.exclamation = new System.Windows.Forms.Button();
            this.hand = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Button();
            this.launch2 = new System.Windows.Forms.Button();
            this.missed1 = new System.Windows.Forms.Button();
            this.laser = new System.Windows.Forms.Button();
            this.foom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asterisk
            // 
            this.asterisk.Location = new System.Drawing.Point(12, 12);
            this.asterisk.Name = "asterisk";
            this.asterisk.Size = new System.Drawing.Size(75, 23);
            this.asterisk.TabIndex = 0;
            this.asterisk.Text = "Asterisk";
            this.asterisk.UseVisualStyleBackColor = true;
            this.asterisk.Click += new System.EventHandler(this.button_Click);
            // 
            // launch1
            // 
            this.launch1.Location = new System.Drawing.Point(124, 12);
            this.launch1.Name = "launch1";
            this.launch1.Size = new System.Drawing.Size(75, 23);
            this.launch1.TabIndex = 0;
            this.launch1.Text = "Launch1";
            this.launch1.UseVisualStyleBackColor = true;
            this.launch1.Click += new System.EventHandler(this.button_Click);
            // 
            // beep
            // 
            this.beep.Location = new System.Drawing.Point(12, 41);
            this.beep.Name = "beep";
            this.beep.Size = new System.Drawing.Size(75, 23);
            this.beep.TabIndex = 0;
            this.beep.Text = "Beep";
            this.beep.UseVisualStyleBackColor = true;
            this.beep.Click += new System.EventHandler(this.button_Click);
            // 
            // exclamation
            // 
            this.exclamation.Location = new System.Drawing.Point(12, 70);
            this.exclamation.Name = "exclamation";
            this.exclamation.Size = new System.Drawing.Size(75, 23);
            this.exclamation.TabIndex = 0;
            this.exclamation.Text = "Exclamation";
            this.exclamation.UseVisualStyleBackColor = true;
            this.exclamation.Click += new System.EventHandler(this.button_Click);
            // 
            // hand
            // 
            this.hand.Location = new System.Drawing.Point(12, 99);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(75, 23);
            this.hand.TabIndex = 0;
            this.hand.Text = "Hand";
            this.hand.UseVisualStyleBackColor = true;
            this.hand.Click += new System.EventHandler(this.button_Click);
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(12, 128);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(75, 23);
            this.question.TabIndex = 0;
            this.question.Text = "Question";
            this.question.UseVisualStyleBackColor = true;
            this.question.Click += new System.EventHandler(this.button_Click);
            // 
            // launch2
            // 
            this.launch2.Location = new System.Drawing.Point(124, 41);
            this.launch2.Name = "launch2";
            this.launch2.Size = new System.Drawing.Size(75, 23);
            this.launch2.TabIndex = 0;
            this.launch2.Text = "Launch2";
            this.launch2.UseVisualStyleBackColor = true;
            this.launch2.Click += new System.EventHandler(this.button_Click);
            // 
            // missed1
            // 
            this.missed1.Location = new System.Drawing.Point(124, 70);
            this.missed1.Name = "missed1";
            this.missed1.Size = new System.Drawing.Size(75, 23);
            this.missed1.TabIndex = 0;
            this.missed1.Text = "Missed1";
            this.missed1.UseVisualStyleBackColor = true;
            this.missed1.Click += new System.EventHandler(this.button_Click);
            // 
            // laser
            // 
            this.laser.Location = new System.Drawing.Point(124, 99);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(75, 23);
            this.laser.TabIndex = 0;
            this.laser.Text = "Laser";
            this.laser.UseVisualStyleBackColor = true;
            this.laser.Click += new System.EventHandler(this.button_Click);
            // 
            // foom
            // 
            this.foom.Location = new System.Drawing.Point(124, 128);
            this.foom.Name = "foom";
            this.foom.Size = new System.Drawing.Size(75, 23);
            this.foom.TabIndex = 0;
            this.foom.Text = "Foom";
            this.foom.UseVisualStyleBackColor = true;
            this.foom.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.foom);
            this.Controls.Add(this.laser);
            this.Controls.Add(this.missed1);
            this.Controls.Add(this.launch2);
            this.Controls.Add(this.launch1);
            this.Controls.Add(this.question);
            this.Controls.Add(this.hand);
            this.Controls.Add(this.exclamation);
            this.Controls.Add(this.beep);
            this.Controls.Add(this.asterisk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button asterisk;
        private System.Windows.Forms.Button launch1;
        private System.Windows.Forms.Button beep;
        private System.Windows.Forms.Button exclamation;
        private System.Windows.Forms.Button hand;
        private System.Windows.Forms.Button question;
        private System.Windows.Forms.Button launch2;
        private System.Windows.Forms.Button missed1;
        private System.Windows.Forms.Button laser;
        private System.Windows.Forms.Button foom;
    }
}

