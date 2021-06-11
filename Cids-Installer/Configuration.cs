using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cids_Installer
{
    public partial class Configuration : Form
    {
        bool TimeShow = false;
        bool ExpandShow = false;
        public Configuration()
        {
            InitializeComponent();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            #region Default Settings
            ProtocolBox.SelectedIndex = 1; // set Tcp as Default
            
            // Net Part
            IpMaskText.Text = "127.0.0.1";
            MainPortText.Text = 20800.ToString();
            MirrorPortText.Text= 20801.ToString();

            // Time Part
            UdpDelayText.Text = 10.ToString();
            HeartBeatText.Text = 1000.ToString();
            LimitText.Text = 10.ToString();
            SleepTimeMinText.Text = 2000.ToString();
            SleepTimeMaxText.Text = 5000.ToString();
            #endregion
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            TimeShow = !TimeShow;// toggel
            TimeBlock.Visible = TimeShow;
            if (TimeShow)// show block
            {
                TimeButton.Text = "关闭时间控制";
            }
            else
            {
                TimeButton.Text = "显示时间控制";
            }
        }

        private void Install_Click(object sender, EventArgs e)
        {
            //todo
            // write conf file
            this.Close();
        }

        private void ExpandButton_Click(object sender, EventArgs e)
        {
            ExpandShow = !ExpandShow;// toggel
            ExpandSetting.Visible = ExpandShow;
            if (ExpandShow)// show block
            {
                ExpandButton.Text = "关闭拓展选项";
            }
            else
            {
                ExpandButton.Text = "显示拓展选项";
            }
        }
    }
}
