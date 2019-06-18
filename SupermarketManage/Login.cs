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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Model.UserInfo model = new Model.UserInfo();//实例化Model层
            model.UserName = txtUserName.Text.Trim();
            model.UserPassword = txtPassword.Text.Trim();
            BLL.UserInfo bll = new BLL.UserInfo(); //实例化BLL层  
            model = bll.ToMD5(model);
            DataSet ds = new DataSet();//定义DataSet对象
            ds = bll.GetList(model);//调用BLL层中的GetList方法，返还DataSet对象
            if (ds.Tables[0].Rows.Count > 0)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或者密码输入错误！");
            }
        }
    }
}
