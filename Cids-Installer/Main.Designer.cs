
namespace Cids_Installer
{
    partial class Installer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installer));
            this.CampusLogo = new System.Windows.Forms.PictureBox();
            this.MainBGWorker = new System.ComponentModel.BackgroundWorker();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.BuildingBox = new System.Windows.Forms.TextBox();
            this.ClassroomBox = new System.Windows.Forms.TextBox();
            this.BuidingTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClassTip = new System.Windows.Forms.ToolTip(this.components);
            this.BGmotto = new System.Windows.Forms.PictureBox();
            this.Help = new System.Windows.Forms.HelpProvider();
            this.InstallerText = new System.Windows.Forms.PictureBox();
            this.BuildList = new System.Windows.Forms.ComboBox();
            this.SelectGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CampusLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGmotto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallerText)).BeginInit();
            this.SelectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CampusLogo
            // 
            this.CampusLogo.Image = ((System.Drawing.Image)(resources.GetObject("CampusLogo.Image")));
            this.CampusLogo.Location = new System.Drawing.Point(12, 12);
            this.CampusLogo.Name = "CampusLogo";
            this.CampusLogo.Size = new System.Drawing.Size(66, 66);
            this.CampusLogo.TabIndex = 0;
            this.CampusLogo.TabStop = false;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(515, 45);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckBtn.TabIndex = 1;
            this.CheckBtn.Text = "查询";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(605, 45);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 2;
            this.ConfirmBtn.Text = "确定\r\n";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // BuildingBox
            // 
            this.BuildingBox.Location = new System.Drawing.Point(6, 47);
            this.BuildingBox.Name = "BuildingBox";
            this.BuildingBox.PlaceholderText = "输入教学楼信息";
            this.BuildingBox.Size = new System.Drawing.Size(162, 23);
            this.BuildingBox.TabIndex = 3;
            this.BuidingTip.SetToolTip(this.BuildingBox, "教学楼示例\r\n九教\r\n实验楼\r\n一教A座\r\n基教楼B座");
            this.BuildingBox.TextChanged += new System.EventHandler(this.BuildingBox_TextChanged);
            // 
            // ClassroomBox
            // 
            this.Help.SetHelpKeyword(this.ClassroomBox, "");
            this.Help.SetHelpString(this.ClassroomBox, "");
            this.ClassroomBox.Location = new System.Drawing.Point(318, 47);
            this.ClassroomBox.Name = "ClassroomBox";
            this.ClassroomBox.PlaceholderText = "输入教室地点";
            this.Help.SetShowHelp(this.ClassroomBox, false);
            this.ClassroomBox.Size = new System.Drawing.Size(191, 23);
            this.ClassroomBox.TabIndex = 4;
            this.ClassTip.SetToolTip(this.ClassroomBox, "教学地点示例\r\n1-1\r\nB302\r\n208\r\n报告厅");
            this.ClassroomBox.TextChanged += new System.EventHandler(this.ClassroomBox_TextChanged);
            // 
            // BuidingTip
            // 
            this.BuidingTip.AutomaticDelay = 0;
            this.BuidingTip.AutoPopDelay = 20000;
            this.BuidingTip.InitialDelay = 20;
            this.BuidingTip.ReshowDelay = 40;
            this.BuidingTip.ShowAlways = true;
            // 
            // ClassTip
            // 
            this.ClassTip.AutomaticDelay = 0;
            this.ClassTip.AutoPopDelay = 20000;
            this.ClassTip.InitialDelay = 20;
            this.ClassTip.ReshowDelay = 40;
            this.ClassTip.ShowAlways = true;
            // 
            // BGmotto
            // 
            this.Help.SetHelpString(this.BGmotto, "先输入教学楼信息 再输入教室地点 查询后 如果该地点存在 则可以点击确定 如果该地点不存在 则可以点击新增");
            this.BGmotto.Image = ((System.Drawing.Image)(resources.GetObject("BGmotto.Image")));
            this.BGmotto.Location = new System.Drawing.Point(173, 87);
            this.BGmotto.Name = "BGmotto";
            this.Help.SetShowHelp(this.BGmotto, true);
            this.BGmotto.Size = new System.Drawing.Size(436, 91);
            this.BGmotto.TabIndex = 5;
            this.BGmotto.TabStop = false;
            // 
            // InstallerText
            // 
            this.InstallerText.Image = ((System.Drawing.Image)(resources.GetObject("InstallerText.Image")));
            this.InstallerText.Location = new System.Drawing.Point(229, 184);
            this.InstallerText.Name = "InstallerText";
            this.InstallerText.Size = new System.Drawing.Size(286, 101);
            this.InstallerText.TabIndex = 6;
            this.InstallerText.TabStop = false;
            // 
            // BuildList
            // 
            this.BuildList.FormattingEnabled = true;
            this.BuildList.Location = new System.Drawing.Point(174, 45);
            this.BuildList.Name = "BuildList";
            this.BuildList.Size = new System.Drawing.Size(138, 25);
            this.BuildList.TabIndex = 7;
            this.BuildList.Visible = false;
            this.BuildList.SelectedIndexChanged += new System.EventHandler(this.BuildList_SelectedIndexChanged);
            // 
            // SelectGroup
            // 
            this.SelectGroup.Controls.Add(this.BuildingBox);
            this.SelectGroup.Controls.Add(this.BuildList);
            this.SelectGroup.Controls.Add(this.ClassroomBox);
            this.SelectGroup.Controls.Add(this.ConfirmBtn);
            this.SelectGroup.Controls.Add(this.CheckBtn);
            this.SelectGroup.Location = new System.Drawing.Point(31, 291);
            this.SelectGroup.Name = "SelectGroup";
            this.SelectGroup.Size = new System.Drawing.Size(697, 100);
            this.SelectGroup.TabIndex = 8;
            this.SelectGroup.TabStop = false;
            // 
            // Installer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectGroup);
            this.Controls.Add(this.InstallerText);
            this.Controls.Add(this.BGmotto);
            this.Controls.Add(this.CampusLogo);
            this.HelpButton = true;
            this.Help.SetHelpString(this, "先输入教学楼信息 再输入教室地点 查询后 如果该地点存在 则可以点击确定 如果该地点不存在 则可以点击新增");
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Installer";
            this.Help.SetShowHelp(this, true);
            this.Text = "Cids-Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CampusLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGmotto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallerText)).EndInit();
            this.SelectGroup.ResumeLayout(false);
            this.SelectGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox CampusLogo;
        private System.ComponentModel.BackgroundWorker MainBGWorker;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.TextBox BuildingBox;
        private System.Windows.Forms.TextBox ClassroomBox;
        private System.Windows.Forms.ToolTip BuidingTip;
        private System.Windows.Forms.ToolTip ClassTip;
        private System.Windows.Forms.PictureBox BGmotto;
        public System.Windows.Forms.HelpProvider Help;
        private System.Windows.Forms.PictureBox InstallerText;
        private System.Windows.Forms.ComboBox BuildList;
        private System.Windows.Forms.GroupBox SelectGroup;
    }
}

