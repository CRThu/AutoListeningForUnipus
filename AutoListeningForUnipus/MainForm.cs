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
    public partial class MainForm : Form
    {
        int totalTimeSecond = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://ucontent.unipus.cn/_pc_default/pc.html?#/course-v1:Unipus+nsce_2_rcls_2+2018_03/courseware/u1/u1g18/u1g19/u1g20/p_1");
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            HtmlElementCollection buttonList = webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement button in buttonList)
            {
                if (button.OuterHtml.IndexOf("audio--aplayer-play-3oL9n") >= 0)
                {
                    buttonStatus.Text = "播放/暂停键状态:\n" + button.OuterHtml.Split('"')[1];
                    button.InvokeMember("click");
                }
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            HtmlElementCollection buttonList = webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement button in buttonList)
            {
                if (button.OuterHtml.IndexOf("audio--aplayer-pause-2vZgP") >= 0)
                {
                    buttonStatus.Text = "播放/暂停键状态:\n" + button.OuterHtml.Split('"')[1];
                    button.InvokeMember("click");
                }
            }
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            // <time class="audio--duration-3HzUa">01:38</time>

            HtmlElementCollection buttonList = webBrowser1.Document.GetElementsByTagName("time");
            foreach (HtmlElement button in buttonList)
            {
                if (button.OuterHtml.IndexOf("audio--duration-3HzUa") >= 0)
                {
                    // "<time class=\"audio--duration-3HzUa\">00:00</time>"
                    var timeStr = button.OuterHtml.Split('<', '>')[2];
                    var ms = timeStr.Split(':');
                    try
                    {
                        timer1.Interval = Convert.ToInt32(ms[0]) * 60 + Convert.ToInt32(ms[1]);
                        timer1.Interval *= 1000;
                        timer1.Interval += 7000;
                        timeStatus.Text = "时间状态:\n" + button.OuterHtml.Split('"')[1] + "\n时长:" + (timer1.Interval / 1000 - 7).ToString() + "秒";
                        startButton_Click(null, null);
                        timer1.Start();
                    }
                    catch (Exception ex)
                    {
                        timeStatus.Text = "音频长度获取失败,等待刷新后重试!";
                        webBrowser1.Refresh();
                    }
                }
            }
        }

        private void stopAutoButton_Click(object sender, EventArgs e)
        {
            pauseButton_Click(null, null);
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int lastHour = totalTimeSecond / 3600;
            totalTimeSecond += timer1.Interval / 1000 - 7;

            int hours, minutes, seconds;
            hours = totalTimeSecond / 3600;
            minutes = (totalTimeSecond - hours * 3600) / 60;
            seconds = totalTimeSecond - hours * 3600 - minutes * 60;
            totalTime.Text = "播放总时间:\n" + hours + "小时" + minutes + "分钟" + seconds + "秒";

            if (RefreshEveryHour.Checked && lastHour != hours)
                webBrowser1.Refresh();
            else
                startButton_Click(null, null);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
