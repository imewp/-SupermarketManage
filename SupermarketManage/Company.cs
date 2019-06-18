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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }
        int flag = 0;//标记   //1.添加  2.修改 3.删除 
        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {
            txtCompanyID.Text = "";
            txtCompanyName.Text = "";
            txtCompanyDirector.Text = "";
            txtCompanyPhone.Text = "";
            txtCompanyAddress.Text = "";
            txtCompanyRemarks.Text = "";
            this.dateTimePicker1.Value = DateTime.Now;
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
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.CompanyInfo bll = new BLL.CompanyInfo();
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dataGridView1.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            flag = 1;
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            txtCompanyID.ReadOnly = true;
            flag = 2;
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            ControlStatus();
            flag = 3;
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            txtCompanyID.ReadOnly = false;
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (txtCompanyID.Text == "" || txtCompanyName.Text == "" || txtCompanyDirector.Text == "" || txtCompanyPhone.Text == "" || txtCompanyAddress.Text == "")
            {
                MessageBox.Show("请将信息添加完整！");
                return;
            } 
            Model.CompanyInfo model = new Model.CompanyInfo();//实例化model层
            model.CompanyID = txtCompanyID.Text.Trim();
            model.CompanyName = txtCompanyName.Text.Trim();
            model.CompanyDirector = txtCompanyDirector.Text.Trim();
            model.CompanyPhone = txtCompanyPhone.Text.Trim();
            model.CompanyAddress = txtCompanyAddress.Text.Trim();
            model.CompanyRemarks = txtCompanyRemarks.Text.Trim();
            model.ReDateTime = DateTime.Parse(dateTimePicker1.Text);
            BLL.CompanyInfo bll = new BLL.CompanyInfo();//实例化BLL层
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

        private void Company_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == 2 || flag == 3)
            {
                txtCompanyID.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
                txtCompanyName.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
                txtCompanyDirector.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
                txtCompanyPhone.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
                txtCompanyAddress.Text = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
                txtCompanyRemarks.Text = dataGridView1.CurrentCell.OwningRow.Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentCell.OwningRow.Cells[6].Value.ToString();
            }
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
            string companyName = txtKeyWord.Text;
            string companyDirector = txtKeyWord.Text;
            switch(strSelect)
            {
                case "供应商名称":
                    {
                        strWhere = strWhere + " and CompanyName like '%" + companyName + "'%";
                    }
                    break;
                case "负责人姓名":
                    {
                        strWhere = strWhere + " and CompanyDirector like '%" + companyDirector + "'%";
                    }
                    break;
            }
            BLL.CompanyInfo bll = new BLL.CompanyInfo(); //实例化BLL层          
            DataSet ds = new DataSet();
            ds = bll.GetList(strWhere);//执行带参数SQL语句，将结果存在ds中
            dataGridView1.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源
        }


    }
}
