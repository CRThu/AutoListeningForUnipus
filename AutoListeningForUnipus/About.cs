using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoListeningForUnipus
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            projectNameLabel.Text = "AutoListeningForUnipus Ver " + ProductVersion.Split('.')[0] + "." + ProductVersion.Split('.')[1];
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(githubLinkLabel.Text);
            About_Click(null, null);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About_Click(null, null);
        }
        private void projectNameLabel_Click(object sender, EventArgs e)
        {
            About_Click(null, null);
        }

        private void MyName_Click(object sender, EventArgs e)
        {
            About_Click(null, null);
        }

    }
}
