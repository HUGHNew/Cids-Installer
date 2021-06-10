﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.CampusLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGmotto)).BeginInit();
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
            this.CampusLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(518, 302);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckBtn.TabIndex = 1;
            this.CheckBtn.Text = "查询";
            this.CheckBtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(620, 302);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 2;
            this.ConfirmBtn.Text = "确定\r\n";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // BuildingBox
            // 
            this.BuildingBox.Location = new System.Drawing.Point(70, 302);
            this.BuildingBox.Name = "BuildingBox";
            this.BuildingBox.PlaceholderText = "输入教学楼信息";
            this.BuildingBox.Size = new System.Drawing.Size(162, 23);
            this.BuildingBox.TabIndex = 3;
            this.BuidingTip.SetToolTip(this.BuildingBox, "教学楼示例\r\n九教\r\n实验楼\r\n一教A座\r\n基教楼B座");
            this.BuildingBox.TextChanged += new System.EventHandler(this.BuildingBox_TextChanged);
            // 
            // ClassroomBox
            // 
            this.ClassroomBox.Location = new System.Drawing.Point(257, 302);
            this.ClassroomBox.Name = "ClassroomBox";
            this.ClassroomBox.PlaceholderText = "输入教室地点";
            this.ClassroomBox.Size = new System.Drawing.Size(191, 23);
            this.ClassroomBox.TabIndex = 4;
            this.ClassTip.SetToolTip(this.ClassroomBox, "教学地点示例\r\n1-1\r\nB302\r\n208\r\n报告厅");
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
            this.BGmotto.Image = ((System.Drawing.Image)(resources.GetObject("BGmotto.Image")));
            this.BGmotto.Location = new System.Drawing.Point(171, 170);
            this.BGmotto.Name = "BGmotto";
            this.BGmotto.Size = new System.Drawing.Size(436, 91);
            this.BGmotto.TabIndex = 5;
            this.BGmotto.TabStop = false;
            // 
            // Installer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BGmotto);
            this.Controls.Add(this.ClassroomBox);
            this.Controls.Add(this.BuildingBox);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.CheckBtn);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

