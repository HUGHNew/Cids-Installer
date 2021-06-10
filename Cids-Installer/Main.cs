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
        private Database database = new Database();
        private IEnumerable<String> todo;
        public Installer()
        {
            InitializeComponent();
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
            //foreach(var it in todo)
            //{
            //    BuildList.Items.Add(it);
            //}
            //BuildList.Items.Add("a");
            //BuildList.Items.Add("b");
            BuildList.EndUpdate();
            BuildList.Visible = true;
        }

        private void BuildList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("Changed");
        }
    }
}
