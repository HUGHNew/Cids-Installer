#define PPT
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
        public static string Id { get; set; }
#if PPT
        private Dictionary<String, String> Campus2Building;
        private Dictionary<String, String> Building2Class;
        private void DataLoad() { 
            //Campus.
        }
#else
        private Database database = new Database(true);
        private IEnumerable<String> todo;
        public const String None = "为未存储信息 请新增";
        public const String ToSelect = "点击查看可选项";
        // 是否选中当前已有教室
        // true -- 不需要数据库中添加
        // false-- 需要在数据库中添加
        private bool Selected = true;
        // whether it is checked
        private bool Submit = false;
#endif
        public Installer()
        {
            InitializeComponent();
        }
        private void DefaultSetting()
        {
            //BuildList.Hide();
            //BuildList.Text =ToSelect ;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DefaultSetting();

        }
#if PPT

#else
        private void BuildingBox_TextChanged(object sender, EventArgs e)
        {
            SubmitBtnSwitch(false);
        }
        private void ClassroomBox_TextChanged(object sender, EventArgs e)
        {
            SubmitBtnSwitch(false);
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
            if (BuildList.Items.Count == 0)
            {
                BuildList.Items.Add(None);
                //BuildList.Items.Add(database.IdCount);
                //todo if none
            }
            BuildList.EndUpdate();
            BuildList.Visible = true;
        }
        //<summary>
        //改变 判断确认能够提交变量 的值
        //改变确定按钮的文本内容
        //</summary>
        private void SubmitBtnSwitch(bool value) {
            Submit = value;
            SubmitBtnSwitch();
        }
        //<summary>改变确定按钮的文本内容</summary>
        private void SubmitBtnSwitch()
        {
            if (Submit){
                ConfirmBtn.Text = Selected ? "确定" : "新增";
            }
            else {
                BuildList.Hide();
                ConfirmBtn.Text = "确定";
            }
            BuildList.Text = ToSelect;
        }

        private void BuildList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected =! (BuildList.SelectedItem as String == None);
            SubmitBtnSwitch(true);
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (BuildList.SelectedItem as String == None)
            {
                Selected = false;
                SubmitBtnSwitch();
                Id=database.Insert(BuildingBox.Text + ClassroomBox.Text);
            }
            else
            {
                Selected = true;
                SubmitBtnSwitch();
                Id = database.QueryAndUpdate(BuildList.SelectedItem as String);
            }
            // Jump To Next Page
        }
        //<summary>安装的最后一步</summary>
        private void WriteToSystem()
        {
            //把信息写入系统 包括配置文件和需要建的文件夹等等
        }
#endif

    }
}
