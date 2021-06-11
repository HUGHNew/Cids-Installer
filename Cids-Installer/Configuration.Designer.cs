
namespace Cids_Installer
{
    partial class Configuration
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
            this.NetBlock = new System.Windows.Forms.GroupBox();
            this.MirrorPortLabel = new System.Windows.Forms.Label();
            this.MainPortLabel = new System.Windows.Forms.Label();
            this.IpLabel = new System.Windows.Forms.Label();
            this.MirrorPortText = new System.Windows.Forms.MaskedTextBox();
            this.MainPortText = new System.Windows.Forms.MaskedTextBox();
            this.IpMaskText = new System.Windows.Forms.MaskedTextBox();
            this.TimeBlock = new System.Windows.Forms.GroupBox();
            this.SleepTimeMaxText = new System.Windows.Forms.MaskedTextBox();
            this.SleepTimeMinText = new System.Windows.Forms.MaskedTextBox();
            this.LimitText = new System.Windows.Forms.MaskedTextBox();
            this.HeartBeatText = new System.Windows.Forms.MaskedTextBox();
            this.UdpDelayText = new System.Windows.Forms.MaskedTextBox();
            this.DelayUdp = new System.Windows.Forms.Label();
            this.SleepTimeMax = new System.Windows.Forms.Label();
            this.SleepTimeMin = new System.Windows.Forms.Label();
            this.SleepTime = new System.Windows.Forms.Label();
            this.Limit = new System.Windows.Forms.Label();
            this.HeatBeat = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ExpandSetting = new System.Windows.Forms.GroupBox();
            this.ProtocolBox = new System.Windows.Forms.ComboBox();
            this.Protocol = new System.Windows.Forms.Label();
            this.TimeButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.Install = new System.Windows.Forms.Button();
            this.NetBlock.SuspendLayout();
            this.TimeBlock.SuspendLayout();
            this.ExpandSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // NetBlock
            // 
            this.NetBlock.Controls.Add(this.MirrorPortLabel);
            this.NetBlock.Controls.Add(this.MainPortLabel);
            this.NetBlock.Controls.Add(this.IpLabel);
            this.NetBlock.Controls.Add(this.MirrorPortText);
            this.NetBlock.Controls.Add(this.MainPortText);
            this.NetBlock.Controls.Add(this.IpMaskText);
            this.NetBlock.Location = new System.Drawing.Point(26, 34);
            this.NetBlock.Name = "NetBlock";
            this.NetBlock.Size = new System.Drawing.Size(272, 145);
            this.NetBlock.TabIndex = 0;
            this.NetBlock.TabStop = false;
            this.NetBlock.Text = "网络相关";
            // 
            // MirrorPortLabel
            // 
            this.MirrorPortLabel.AutoSize = true;
            this.MirrorPortLabel.Location = new System.Drawing.Point(4, 111);
            this.MirrorPortLabel.Name = "MirrorPortLabel";
            this.MirrorPortLabel.Size = new System.Drawing.Size(80, 17);
            this.MirrorPortLabel.TabIndex = 8;
            this.MirrorPortLabel.Text = "从服务器端口";
            // 
            // MainPortLabel
            // 
            this.MainPortLabel.AutoSize = true;
            this.MainPortLabel.Location = new System.Drawing.Point(4, 70);
            this.MainPortLabel.Name = "MainPortLabel";
            this.MainPortLabel.Size = new System.Drawing.Size(80, 17);
            this.MainPortLabel.TabIndex = 7;
            this.MainPortLabel.Text = "主服务器端口";
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(14, 32);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(55, 17);
            this.IpLabel.TabIndex = 6;
            this.IpLabel.Text = "服务器IP";
            // 
            // MirrorPortText
            // 
            this.MirrorPortText.Location = new System.Drawing.Point(90, 108);
            this.MirrorPortText.Mask = "99999";
            this.MirrorPortText.Name = "MirrorPortText";
            this.MirrorPortText.PromptChar = ' ';
            this.MirrorPortText.Size = new System.Drawing.Size(100, 23);
            this.MirrorPortText.TabIndex = 2;
            this.MirrorPortText.ValidatingType = typeof(int);
            // 
            // MainPortText
            // 
            this.MainPortText.Location = new System.Drawing.Point(90, 67);
            this.MainPortText.Mask = "99999";
            this.MainPortText.Name = "MainPortText";
            this.MainPortText.PromptChar = ' ';
            this.MainPortText.Size = new System.Drawing.Size(100, 23);
            this.MainPortText.TabIndex = 1;
            this.MainPortText.ValidatingType = typeof(int);
            // 
            // IpMaskText
            // 
            this.IpMaskText.Location = new System.Drawing.Point(90, 29);
            this.IpMaskText.Mask = "127.\\0.\\0.1";
            this.IpMaskText.Name = "IpMaskText";
            this.IpMaskText.Size = new System.Drawing.Size(100, 23);
            this.IpMaskText.TabIndex = 0;
            // 
            // TimeBlock
            // 
            this.TimeBlock.Controls.Add(this.SleepTimeMaxText);
            this.TimeBlock.Controls.Add(this.SleepTimeMinText);
            this.TimeBlock.Controls.Add(this.LimitText);
            this.TimeBlock.Controls.Add(this.HeartBeatText);
            this.TimeBlock.Controls.Add(this.UdpDelayText);
            this.TimeBlock.Controls.Add(this.DelayUdp);
            this.TimeBlock.Controls.Add(this.SleepTimeMax);
            this.TimeBlock.Controls.Add(this.SleepTimeMin);
            this.TimeBlock.Controls.Add(this.SleepTime);
            this.TimeBlock.Controls.Add(this.Limit);
            this.TimeBlock.Controls.Add(this.HeatBeat);
            this.TimeBlock.Controls.Add(this.Title);
            this.TimeBlock.Location = new System.Drawing.Point(453, 35);
            this.TimeBlock.Name = "TimeBlock";
            this.TimeBlock.Size = new System.Drawing.Size(258, 153);
            this.TimeBlock.TabIndex = 1;
            this.TimeBlock.TabStop = false;
            this.TimeBlock.Text = "时间控制";
            this.TimeBlock.Visible = false;
            // 
            // SleepTimeMaxText
            // 
            this.SleepTimeMaxText.Location = new System.Drawing.Point(190, 124);
            this.SleepTimeMaxText.Mask = "9999";
            this.SleepTimeMaxText.Name = "SleepTimeMaxText";
            this.SleepTimeMaxText.PromptChar = ' ';
            this.SleepTimeMaxText.Size = new System.Drawing.Size(68, 23);
            this.SleepTimeMaxText.TabIndex = 11;
            this.SleepTimeMaxText.ValidatingType = typeof(int);
            // 
            // SleepTimeMinText
            // 
            this.SleepTimeMinText.Location = new System.Drawing.Point(56, 124);
            this.SleepTimeMinText.Mask = "9999";
            this.SleepTimeMinText.Name = "SleepTimeMinText";
            this.SleepTimeMinText.PromptChar = ' ';
            this.SleepTimeMinText.Size = new System.Drawing.Size(65, 23);
            this.SleepTimeMinText.TabIndex = 10;
            this.SleepTimeMinText.ValidatingType = typeof(int);
            // 
            // LimitText
            // 
            this.LimitText.Location = new System.Drawing.Point(93, 83);
            this.LimitText.Mask = "999";
            this.LimitText.Name = "LimitText";
            this.LimitText.PromptChar = ' ';
            this.LimitText.Size = new System.Drawing.Size(100, 23);
            this.LimitText.TabIndex = 9;
            this.LimitText.ValidatingType = typeof(int);
            // 
            // HeartBeatText
            // 
            this.HeartBeatText.Location = new System.Drawing.Point(93, 54);
            this.HeartBeatText.Mask = "9999";
            this.HeartBeatText.Name = "HeartBeatText";
            this.HeartBeatText.PromptChar = ' ';
            this.HeartBeatText.Size = new System.Drawing.Size(100, 23);
            this.HeartBeatText.TabIndex = 8;
            this.HeartBeatText.ValidatingType = typeof(int);
            // 
            // UdpDelayText
            // 
            this.UdpDelayText.Location = new System.Drawing.Point(93, 25);
            this.UdpDelayText.Mask = "9999";
            this.UdpDelayText.Name = "UdpDelayText";
            this.UdpDelayText.PromptChar = ' ';
            this.UdpDelayText.Size = new System.Drawing.Size(100, 23);
            this.UdpDelayText.TabIndex = 7;
            this.UdpDelayText.ValidatingType = typeof(int);
            // 
            // DelayUdp
            // 
            this.DelayUdp.AutoSize = true;
            this.DelayUdp.Location = new System.Drawing.Point(22, 28);
            this.DelayUdp.Name = "DelayUdp";
            this.DelayUdp.Size = new System.Drawing.Size(56, 17);
            this.DelayUdp.TabIndex = 1;
            this.DelayUdp.Text = "每次发包";
            // 
            // SleepTimeMax
            // 
            this.SleepTimeMax.AutoSize = true;
            this.SleepTimeMax.Location = new System.Drawing.Point(140, 127);
            this.SleepTimeMax.Name = "SleepTimeMax";
            this.SleepTimeMax.Size = new System.Drawing.Size(44, 17);
            this.SleepTimeMax.TabIndex = 6;
            this.SleepTimeMax.Text = "最大值";
            // 
            // SleepTimeMin
            // 
            this.SleepTimeMin.AutoSize = true;
            this.SleepTimeMin.Location = new System.Drawing.Point(6, 127);
            this.SleepTimeMin.Name = "SleepTimeMin";
            this.SleepTimeMin.Size = new System.Drawing.Size(44, 17);
            this.SleepTimeMin.TabIndex = 5;
            this.SleepTimeMin.Text = "最小值";
            // 
            // SleepTime
            // 
            this.SleepTime.AutoSize = true;
            this.SleepTime.Location = new System.Drawing.Point(72, 107);
            this.SleepTime.Name = "SleepTime";
            this.SleepTime.Size = new System.Drawing.Size(80, 17);
            this.SleepTime.TabIndex = 4;
            this.SleepTime.Text = "睡眠时间控制";
            // 
            // Limit
            // 
            this.Limit.AutoSize = true;
            this.Limit.Location = new System.Drawing.Point(7, 83);
            this.Limit.Name = "Limit";
            this.Limit.Size = new System.Drawing.Size(80, 17);
            this.Limit.TabIndex = 3;
            this.Limit.Text = "心跳判亡次数";
            // 
            // HeatBeat
            // 
            this.HeatBeat.AutoSize = true;
            this.HeatBeat.Location = new System.Drawing.Point(0, 57);
            this.HeatBeat.Name = "HeatBeat";
            this.HeatBeat.Size = new System.Drawing.Size(92, 17);
            this.HeatBeat.TabIndex = 2;
            this.HeatBeat.Text = "心跳包间隔时间";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(72, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(92, 17);
            this.Title.TabIndex = 0;
            this.Title.Text = "时间单位为毫秒";
            // 
            // ExpandSetting
            // 
            this.ExpandSetting.Controls.Add(this.ProtocolBox);
            this.ExpandSetting.Controls.Add(this.Protocol);
            this.ExpandSetting.Location = new System.Drawing.Point(453, 204);
            this.ExpandSetting.Name = "ExpandSetting";
            this.ExpandSetting.Size = new System.Drawing.Size(230, 127);
            this.ExpandSetting.TabIndex = 2;
            this.ExpandSetting.TabStop = false;
            this.ExpandSetting.Text = "拓展选项";
            this.ExpandSetting.Visible = false;
            // 
            // ProtocolBox
            // 
            this.ProtocolBox.FormattingEnabled = true;
            this.ProtocolBox.Items.AddRange(new object[] {
            "Udp",
            "Tcp",
            "Quic"});
            this.ProtocolBox.Location = new System.Drawing.Point(52, 62);
            this.ProtocolBox.Name = "ProtocolBox";
            this.ProtocolBox.Size = new System.Drawing.Size(121, 25);
            this.ProtocolBox.TabIndex = 2;
            this.ProtocolBox.Text = "协议选择";
            // 
            // Protocol
            // 
            this.Protocol.AutoSize = true;
            this.Protocol.Location = new System.Drawing.Point(52, 42);
            this.Protocol.Name = "Protocol";
            this.Protocol.Size = new System.Drawing.Size(128, 17);
            this.Protocol.TabIndex = 1;
            this.Protocol.Text = "从服务器通信协议选择";
            // 
            // TimeButton
            // 
            this.TimeButton.Location = new System.Drawing.Point(304, 41);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(91, 23);
            this.TimeButton.TabIndex = 12;
            this.TimeButton.Text = "显示时间控制";
            this.TimeButton.UseVisualStyleBackColor = true;
            this.TimeButton.Click += new System.EventHandler(this.TimeButton_Click);
            // 
            // ExpandButton
            // 
            this.ExpandButton.Location = new System.Drawing.Point(304, 86);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(91, 23);
            this.ExpandButton.TabIndex = 13;
            this.ExpandButton.Text = "显示拓展选项";
            this.ExpandButton.UseVisualStyleBackColor = true;
            this.ExpandButton.Click += new System.EventHandler(this.ExpandButton_Click);
            // 
            // Install
            // 
            this.Install.Location = new System.Drawing.Point(268, 358);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(189, 80);
            this.Install.TabIndex = 14;
            this.Install.Text = "完成安装";
            this.Install.UseVisualStyleBackColor = true;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.TimeButton);
            this.Controls.Add(this.ExpandSetting);
            this.Controls.Add(this.TimeBlock);
            this.Controls.Add(this.NetBlock);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.NetBlock.ResumeLayout(false);
            this.NetBlock.PerformLayout();
            this.TimeBlock.ResumeLayout(false);
            this.TimeBlock.PerformLayout();
            this.ExpandSetting.ResumeLayout(false);
            this.ExpandSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NetBlock;
        private System.Windows.Forms.GroupBox TimeBlock;
        private System.Windows.Forms.MaskedTextBox IpMaskText;
        private System.Windows.Forms.MaskedTextBox MirrorPortText;
        private System.Windows.Forms.MaskedTextBox MainPortText;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Label MirrorPortLabel;
        private System.Windows.Forms.Label MainPortLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SleepTimeMax;
        private System.Windows.Forms.Label SleepTimeMin;
        private System.Windows.Forms.Label SleepTime;
        private System.Windows.Forms.Label Limit;
        private System.Windows.Forms.Label HeatBeat;
        private System.Windows.Forms.Label Delay;
        private System.Windows.Forms.Label DelayUdp;
        private System.Windows.Forms.GroupBox ExpandSetting;
        private System.Windows.Forms.MaskedTextBox LimitText;
        private System.Windows.Forms.MaskedTextBox HeartBeatText;
        private System.Windows.Forms.MaskedTextBox UdpDelayText;
        private System.Windows.Forms.MaskedTextBox SleepTimeMaxText;
        private System.Windows.Forms.MaskedTextBox SleepTimeMinText;
        private System.Windows.Forms.Label Protocol;
        private System.Windows.Forms.ComboBox ProtocolBox;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button Install;
    }
}