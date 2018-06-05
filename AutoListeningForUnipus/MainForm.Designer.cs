namespace AutoListeningForUnipus
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.autoButton = new System.Windows.Forms.Button();
            this.timeStatus = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAutoButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1188, 982);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.startButton.Location = new System.Drawing.Point(1256, 381);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(182, 104);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "播放键选中";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.pauseButton.Location = new System.Drawing.Point(1256, 516);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(182, 104);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "暂停键选中";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonStatus.Location = new System.Drawing.Point(1206, 39);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(292, 67);
            this.buttonStatus.TabIndex = 3;
            this.buttonStatus.Text = "播放/暂停键状态:\r\n*******************";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 180000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // autoButton
            // 
            this.autoButton.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.autoButton.Location = new System.Drawing.Point(1256, 682);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(182, 104);
            this.autoButton.TabIndex = 4;
            this.autoButton.Text = "开始自动播放";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // timeStatus
            // 
            this.timeStatus.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.timeStatus.Location = new System.Drawing.Point(1206, 116);
            this.timeStatus.Name = "timeStatus";
            this.timeStatus.Size = new System.Drawing.Size(292, 97);
            this.timeStatus.TabIndex = 5;
            this.timeStatus.Text = "时间状态:\r\n*******************\r\n时长: ***秒";
            // 
            // totalTime
            // 
            this.totalTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.totalTime.Location = new System.Drawing.Point(1206, 232);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(292, 69);
            this.totalTime.TabIndex = 6;
            this.totalTime.Text = "播放总时间:\r\n00小时00分钟00秒";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1510, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // stopAutoButton
            // 
            this.stopAutoButton.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.stopAutoButton.Location = new System.Drawing.Point(1256, 811);
            this.stopAutoButton.Name = "stopAutoButton";
            this.stopAutoButton.Size = new System.Drawing.Size(182, 104);
            this.stopAutoButton.TabIndex = 8;
            this.stopAutoButton.Text = "暂停自动播放";
            this.stopAutoButton.UseVisualStyleBackColor = true;
            this.stopAutoButton.Click += new System.EventHandler(this.stopAutoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 1033);
            this.Controls.Add(this.stopAutoButton);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.timeStatus);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "AutoListeningForUnipus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label buttonStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Label timeStatus;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button stopAutoButton;
    }
}

