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
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }

        int flag = 0;//标记   //1.添加  2.修改 3.删除

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {

            txtUserName.Text = "";
            txtUserPassword.Text = "";
            cboUserType.Text = "";
        }
        /// <summary>
        /// 控制控件状态
        /// </summary>
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.toolDelete.Enabled = !this.toolDelete.Enabled;
        }
        void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.UserInfo bll = new BLL.UserInfo();
            DataSet ds = new DataSet();
            ds = bll.GetList();
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void UserManage_Load(object sender, EventArgs e)//调用DataBind将数据传到dataGridView1中
        {
            DataBind();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)//修改
        {
            ControlStatus();
            txtUserName.ReadOnly = true;
            flag = 2;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)//点击dataGridView2将数据同步在txetbox中
        {
            if (flag == 2 || flag == 3)
            {
                txtUserName.Text = dataGridView2.CurrentCell.OwningRow.Cells[0].Value.ToString();
                txtUserPassword.Text = dataGridView2.CurrentCell.OwningRow.Cells[1].Value.ToString();
                cboUserType.Text = dataGridView2.CurrentCell.OwningRow.Cells[2].Value.ToString();
            }
        }

        private void toolAdd_Click(object sender, EventArgs e)//添加
        {
            ClearControls();
            ControlStatus();
            flag = 1;
        }

        private void toolDelete_Click(object sender, EventArgs e)//删除
        {
            ControlStatus();
            flag = 3;
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtUserPassword.Text == "" || cboUserType.Text == "" )
            {
                MessageBox.Show("请将信息添加完整！");
                return;
            }
            Model.UserInfo model = new Model.UserInfo();//实例化model层
            model.UserName = txtUserName.Text.Trim();
            model.UserPassword = txtUserPassword.Text.Trim();
            model.UserType = cboUserType.Text.Trim();
            BLL.UserInfo bll = new BLL.UserInfo();//实例化BLL层
            model = bll.ToMD5(model);
            switch (flag)
            {
                case 0:
                    {

                    } break;
                case 1:
                    {
                        if (bll.Add(model))//将员工信息添加到数据库中，根据返回值判断是否添加成功
                        {
                            DataBind();//窗体登录时绑定数据到DataGridView
                            ControlStatus();
                        }
                    } break;
                case 2:
                    {
                        if (bll.Update(model))//根据返回布尔值判断是否修改数据成功
                        {
                            DataBind();//窗体登录时绑定数据到DataGridView
                            ControlStatus();
                        }
                    } break;
                case 3:
                    {
                        if (bll.Delete(model))//根据返回布尔值判断是否删除数据成功
                        {
                            DataBind();//窗体登录时绑定数据到DataGridView
                            ControlStatus();
                        }
                    } break;
            }
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            txtUserName.ReadOnly = false;
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOK_Click(object sender, EventArgs e)
        {
            string strSelect = this.cbxCondition.Text.Trim();
            if (strSelect == "")
            {
                MessageBox.Show("请选择查询条件！");
                return;
            }
            if (this.txtKeyWord.Text == "")
            {
                MessageBox.Show("输入查询条件！");
                return;
            }
            string strWhere = "1=1";
            string userName = txtKeyWord.Text;
            string userType = txtKeyWord.Text;
            switch (strSelect)
            {
                case "用户账号":
                    {
                        strWhere = strWhere + " and UserName like '%" + userName + "%' ";
                    }
                    break;
                case "用户类型":
                    {
                        strWhere = strWhere + " and UserType =  '" + userType + "'";
                    }
                    break;
            }
            BLL.UserInfo bll = new BLL.UserInfo(); //实例化BLL层          
            DataSet ds = new DataSet();
            ds = bll.GetList(strWhere);//执行带参数SQL语句，将结果存在ds中
            dataGridView2.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源
        }
    }
}
