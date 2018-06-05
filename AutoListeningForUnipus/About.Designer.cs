namespace AutoListeningForUnipus
{
    partial class About
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
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.MyName = new System.Windows.Forms.Label();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.projectNameLabel.ForeColor = System.Drawing.Color.White;
            this.projectNameLabel.Location = new System.Drawing.Point(69, 328);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(373, 31);
            this.projectNameLabel.TabIndex = 6;
            this.projectNameLabel.Text = "AutoListeningForUnipus Ver x.x";
            this.projectNameLabel.Click += new System.EventHandler(this.projectNameLabel_Click);
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.MyName.ForeColor = System.Drawing.Color.White;
            this.MyName.Location = new System.Drawing.Point(165, 382);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(170, 31);
            this.MyName.TabIndex = 7;
            this.MyName.Text = "yummyCarrot";
            this.MyName.Click += new System.EventHandler(this.MyName_Click);
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.githubLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.githubLinkLabel.Location = new System.Drawing.Point(64, 428);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(378, 31);
            this.githubLinkLabel.TabIndex = 8;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "https://www.github.com/CRThu";
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoListeningForUnipus.Properties.Resources.MyIcon;
            this.pictureBox1.Location = new System.Drawing.Point(100, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(500, 479);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.MyName);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.About_Load);
            this.Click += new System.EventHandler(this.About_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
    }
}