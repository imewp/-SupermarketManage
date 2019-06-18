using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupermarketManage
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.statuslblTime.Text = "当前时间：" + DateTime.Now.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void 启动WordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //辅助工具-启动Word
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //辅助工具-登录网络
            System.Diagnostics.Process.Start("https://www.baidu.com/");
        }

        private void 启动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //辅助工具-启动Excel
            System.Diagnostics.Process.Start("excel.EXE");
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void 直接退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbtnCheckIn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.MdiParent = this;
            employee.Show();
        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.MdiParent = this;
            employee.Show();
            
        }

        private void 供应商信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.MdiParent = this;
            company.Show();
        }
    }
}
