
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installer));
            this.CampusLogo = new System.Windows.Forms.PictureBox();
            this.MainBGWorker = new System.ComponentModel.BackgroundWorker();
            this.BGmotto = new System.Windows.Forms.PictureBox();
            this.InstallerText = new System.Windows.Forms.PictureBox();
            this.ComboGroup = new System.Windows.Forms.GroupBox();
            this.Campus = new System.Windows.Forms.ComboBox();
            this.Building = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CampusLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGmotto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallerText)).BeginInit();
            this.ComboGroup.SuspendLayout();
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
            // BGmotto
            // 
            this.BGmotto.Image = ((System.Drawing.Image)(resources.GetObject("BGmotto.Image")));
            this.BGmotto.Location = new System.Drawing.Point(173, 87);
            this.BGmotto.Name = "BGmotto";
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
            // ComboGroup
            // 
            this.ComboGroup.Controls.Add(this.Confirm);
            this.ComboGroup.Controls.Add(this.Class);
            this.ComboGroup.Controls.Add(this.Building);
            this.ComboGroup.Controls.Add(this.Campus);
            this.ComboGroup.Location = new System.Drawing.Point(58, 311);
            this.ComboGroup.Name = "ComboGroup";
            this.ComboGroup.Size = new System.Drawing.Size(682, 100);
            this.ComboGroup.TabIndex = 7;
            this.ComboGroup.TabStop = false;
            this.ComboGroup.Text = "教室地点选择";
            // 
            // Campus
            // 
            this.Campus.FormattingEnabled = true;
            this.Campus.Items.AddRange(new object[] {
            "望江",
            "华西",
            "江安"});
            this.Campus.Location = new System.Drawing.Point(28, 46);
            this.Campus.Name = "Campus";
            this.Campus.Size = new System.Drawing.Size(121, 25);
            this.Campus.TabIndex = 0;
            this.Campus.Text = "校区";
            // 
            // Building
            // 
            this.Building.FormattingEnabled = true;
            this.Building.Items.AddRange(new object[] {
            "高分子学院",
            "纺工楼A座",
            "四教",
            "滨江楼",
            "数学学院",
            "一教",
            "二教",
            "三教",
            "管理楼",
            "经管楼",
            "基教楼A座",
            "纺工楼B楼",
            "外文楼",
            "五教",
            "实验室",
            "体育馆",
            "文华活动中心",
            "基教楼C座",
            "公共管理学院",
            "皮革楼",
            "文理图书馆",
            "水电学院",
            "体育学院",
            "研究生院三区",
            "生命学院",
            "藏学研究所",
            "电气楼",
            "物理馆",
            "经济学院",
            "基教楼B座",
            "学生就业指导中心",
            "化学馆",
            "制造学院",
            "体育馆",
            "西区逸夫科技楼",
            "自然博物馆",
            "研究生院二区",
            "展业大厦",
            "研究生院三区",
            "在线考试虚拟考场",
            "文科楼"});
            this.Building.Location = new System.Drawing.Point(181, 46);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(121, 25);
            this.Building.TabIndex = 1;
            this.Building.Text = "教学楼";
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            "A304",
            "A305",
            "A306",
            "A307",
            "A308",
            "A311",
            "A312",
            "A314",
            "A316",
            "A317",
            "A318",
            "A319",
            "A320",
            "A401",
            "A402",
            "A403",
            "A404",
            "A405",
            "A406",
            "A407",
            "A408",
            "A411",
            "A412",
            "A414",
            "A416",
            "A417",
            "A418",
            "A419",
            "A420",
            "A501",
            "A502",
            "A503",
            "A504",
            "A505",
            "A506",
            "A507",
            "A508",
            "A511",
            "A512",
            "A514",
            "A601",
            "A602",
            "A603",
            "A604",
            "A606",
            "A607",
            "A610",
            "A302",
            "A207",
            "A311B",
            "A311A",
            "A311C",
            "A311D",
            "A312A",
            "A312B",
            "A312C",
            "A312D"});
            this.Class.Location = new System.Drawing.Point(336, 46);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(121, 25);
            this.Class.TabIndex = 2;
            this.Class.Text = "教室";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(549, 46);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(62, 25);
            this.Confirm.TabIndex = 3;
            this.Confirm.Text = "确定";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // Installer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboGroup);
            this.Controls.Add(this.InstallerText);
            this.Controls.Add(this.BGmotto);
            this.Controls.Add(this.CampusLogo);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Installer";
            this.Text = "Cids-Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CampusLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGmotto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallerText)).EndInit();
            this.ComboGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox CampusLogo;
        private System.ComponentModel.BackgroundWorker MainBGWorker;
        private System.Windows.Forms.PictureBox BGmotto;
        private System.Windows.Forms.PictureBox InstallerText;
        private System.Windows.Forms.GroupBox ComboGroup;
        private System.Windows.Forms.ComboBox Campus;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.ComboBox Building;
    }
}

