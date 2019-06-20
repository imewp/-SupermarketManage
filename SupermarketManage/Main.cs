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
        //定义新皮肤
        Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();

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
            //选择皮肤文件
            skin.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\" + "DiamondBlue.ssk";
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


        private void tsbtnCheckIn_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Employee employee = new Employee();
                employee.MdiParent = this;
                employee.Show();
            }
        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Employee employee = new Employee();
                employee.MdiParent = this;
                employee.Show();
            }
            
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                UserManage um = new UserManage();
                um.MdiParent = this;
                um.Show();
            }
        }

        private void 供应商信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                Company c = new Company();
                c.MdiParent = this;
                c.Show();
            }
        }

        private void 商品进货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                JHGoods jh = new JHGoods();
                jh.MdiParent = this;
                jh.Show();
            }
        }

        private void tsbtnBookRoom_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                JHGoods jh = new JHGoods();
                jh.MdiParent = this;
                jh.Show();
            }
        }

        private void 主题一ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //选择皮肤文件
            skin.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\" + "DiamondBlue.ssk";
            skin.SkinDialogs = false;
            skin.Active = true;
        }

        private void 主题二ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //选择皮肤文件
            skin.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\" + "DiamondOlive.ssk";
            skin.SkinDialogs = false;
            skin.Active = true;
        }

        private void 主题三ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //选择皮肤文件
            skin.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\" + "DiamondPurple.ssk";
            skin.SkinDialogs = false;
            skin.Active = true;
        }

        private void 主题四ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //选择皮肤文件
            skin.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\" + "DiamondRed.ssk";
            skin.SkinDialogs = false;
            skin.Active = true;
        }

        private void 直接退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //退出-直接退出
            Application.Exit();
        }

        private void 商品查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                GoodsSelect gs = new GoodsSelect();
                gs.MdiParent = this;
                gs.Show();
            }
            
        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                KCGoodsFind kc = new KCGoodsFind();
                kc.MdiParent = this;
                kc.Show();
            }
        }

        private void tsbtnRoomSearch_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                KCGoodsFind kc = new KCGoodsFind();
                kc.MdiParent = this;
                kc.Show();
            }
        }

        private void 库存报警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                KCAlarmNum kn = new KCAlarmNum();
                kn.MdiParent = this;
                kn.Show();
            }
            
        }

        private void 商品销售ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                SellGoods sg = new SellGoods();
                sg.MdiParent = this;
                sg.Show();
            }
           
        }

        private void 商品退货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                ThGoodsInfo sg = new ThGoodsInfo();
                sg.MdiParent = this;
                sg.Show();
            }
        }

        private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                DataBackup backup = new DataBackup();
                backup.MdiParent = this;
                backup.Show();
            }
            
        }

        private void 数据还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                DataReduction dr = new DataReduction();
                dr.MdiParent = this;
                dr.Show();
            }
        }
    }
}
