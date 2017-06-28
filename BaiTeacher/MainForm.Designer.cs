namespace BaiTeacher
{
    partial class frmMain
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
            this.tcListenWrite = new System.Windows.Forms.TabControl();
            this.tplistenWrite = new System.Windows.Forms.TabPage();
            this.clbWord = new System.Windows.Forms.CheckedListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tcListenWrite.SuspendLayout();
            this.tplistenWrite.SuspendLayout();
            this.tpConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // tcListenWrite
            // 
            this.tcListenWrite.Controls.Add(this.tplistenWrite);
            this.tcListenWrite.Controls.Add(this.tpConfig);
            this.tcListenWrite.Location = new System.Drawing.Point(28, 33);
            this.tcListenWrite.Name = "tcListenWrite";
            this.tcListenWrite.SelectedIndex = 0;
            this.tcListenWrite.Size = new System.Drawing.Size(928, 743);
            this.tcListenWrite.TabIndex = 0;
            // 
            // tplistenWrite
            // 
            this.tplistenWrite.Controls.Add(this.clbWord);
            this.tplistenWrite.Controls.Add(this.btnGo);
            this.tplistenWrite.Controls.Add(this.btnFile);
            this.tplistenWrite.Controls.Add(this.tbFile);
            this.tplistenWrite.Controls.Add(this.label1);
            this.tplistenWrite.Location = new System.Drawing.Point(4, 28);
            this.tplistenWrite.Name = "tplistenWrite";
            this.tplistenWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tplistenWrite.Size = new System.Drawing.Size(920, 711);
            this.tplistenWrite.TabIndex = 0;
            this.tplistenWrite.Text = "听写";
            this.tplistenWrite.UseVisualStyleBackColor = true;
            // 
            // clbWord
            // 
            this.clbWord.FormattingEnabled = true;
            this.clbWord.Location = new System.Drawing.Point(63, 133);
            this.clbWord.Name = "clbWord";
            this.clbWord.Size = new System.Drawing.Size(206, 556);
            this.clbWord.TabIndex = 4;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(57, 85);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(839, 33);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "开始听写";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(846, 34);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(43, 30);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(146, 36);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(683, 28);
            this.tbFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "文本路径:";
            // 
            // tpConfig
            // 
            this.tpConfig.Controls.Add(this.nudSecond);
            this.tpConfig.Controls.Add(this.label2);
            this.tpConfig.Location = new System.Drawing.Point(4, 28);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfig.Size = new System.Drawing.Size(920, 711);
            this.tpConfig.TabIndex = 1;
            this.tpConfig.Text = "配置";
            this.tpConfig.UseVisualStyleBackColor = true;
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(135, 24);
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(61, 28);
            this.nudSecond.TabIndex = 1;
            this.nudSecond.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "延迟秒数:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 804);
            this.Controls.Add(this.tcListenWrite);
            this.Name = "frmMain";
            this.Text = "白老师";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcListenWrite.ResumeLayout(false);
            this.tplistenWrite.ResumeLayout(false);
            this.tplistenWrite.PerformLayout();
            this.tpConfig.ResumeLayout(false);
            this.tpConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcListenWrite;
        private System.Windows.Forms.TabPage tplistenWrite;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckedListBox clbWord;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.Label label2;
    }
}

