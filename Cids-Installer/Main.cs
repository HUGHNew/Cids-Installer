using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cids_Installer
{
    public partial class Installer : Form
    {
        private Database database = new Database(true);
        private IEnumerable<String> todo;
        public const String None = "为未存储信息 请新增";
        private bool ConfirmLock = false;
        public Installer()
        {
            InitializeComponent();
            DefaultSetting();
        }
        private void DefaultSetting()
        {
            //BuildList.Hide();
            BuildList.Text = "点击查看可选项";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BuildingBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            BuildList.Visible = false;
            todo=database.Check(this.BuildingBox.Text, this.ClassroomBox.Text);
            BuildList.BeginUpdate();
            BuildList.Items.Clear();
            foreach (var it in todo)
            {
                BuildList.Items.Add(it);
            }
            //BuildList.Items.Add("a");
            //BuildList.Items.Add("b");
            if (BuildList.Items.Count == 0)
            {
                //BuildList.Items.Add(None);
                BuildList.Items.Add(database.IdCount);
                //todo if none
            }
            BuildList.EndUpdate();
            BuildList.Visible = true;
        }

        private void BuildList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
