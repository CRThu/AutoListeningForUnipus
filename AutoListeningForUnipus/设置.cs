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
    public partial class 设置 : Form
    {
        public 设置()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.URL = textBox1.Text;
        }

        private void 设置_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.URL;
        }
    }
}
