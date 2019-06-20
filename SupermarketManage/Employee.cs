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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        
        int flag = 0;//标记   //1.添加  2.修改 3.删除 
        private void toolAdd_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            flag = 1;
        }
        private void toolDelete_Click(object sender, EventArgs e)
        {
            ControlStatus();
            flag = 3;
        }
        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            txtEmployeeID.ReadOnly = true;
            flag = 2;
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            txtEmployeeID.ReadOnly = false;
            flag = 0;
        }

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {

            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtEmployeeAddress.Text = "";
            cboSex.SelectedIndex = 0;
            this.dateTimePicker1.Value = DateTime.Now;
            cmbEmployeeDepartment.SelectedIndex = 0;
            cmbEmployeePost.SelectedIndex = 0;
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

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "" || txtEmployeeName.Text == "" || txtEmail.Text == "" || txtEmployeeAddress.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("请将信息添加完整！");
                return;
            }
            Model.EmployeeInfo model = new Model.EmployeeInfo();//实例化model层
            model.EmployeeID = txtEmployeeID.Text.Trim();
            model.EmployeeName = txtEmployeeName.Text.Trim();
            model.Sex = cboSex.Text.Trim();
            model.EmployeeBirthday = DateTime.Parse(dateTimePicker1.Text);
            model.EmployeeDepartment = cmbEmployeeDepartment.Text;
            model.EmployeePost = cmbEmployeePost.Text;
            model.EmployeePhone = txtPhone.Text.Trim();
            model.EmployeeEmail = txtEmail.Text;
            model.EmployeeAddress = txtEmployeeAddress.Text;
            BLL.Employee bll = new BLL.Employee();//实例化BLL层
            switch(flag)
            {
                case 0: { 
                            
                        } break;
                case 1:  {
                            if (bll.Add(model))//将员工信息添加到数据库中，根据返回值判断是否添加成功
                            {
                                DataBind();//窗体登录时绑定数据到DataGridView
                                ControlStatus();
                            }
                        } break;
                case 2: {
                             if (bll.Update(model))//根据返回布尔值判断是否修改数据成功
                            {
                                DataBind();//窗体登录时绑定数据到DataGridView
                                ControlStatus();
                            }
                        } break;
                case 3: {
                            if (bll.Delete(model))//根据返回布尔值判断是否删除数据成功
                            {
                                DataBind();//窗体登录时绑定数据到DataGridView
                                ControlStatus();
                            }
                        } break;
            }
        }


        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.Employee bll = new BLL.Employee();
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dataGridView1.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == 2 || flag == 3)
            {
                txtEmployeeID.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
                txtEmployeeName.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
                cboSex.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
                cmbEmployeeDepartment.Text= dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
                cmbEmployeePost.Text = dataGridView1.CurrentCell.OwningRow.Cells[5].Value.ToString();
                txtPhone.Text = dataGridView1.CurrentCell.OwningRow.Cells[6].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentCell.OwningRow.Cells[7].Value.ToString();
                txtEmployeeAddress.Text = dataGridView1.CurrentCell.OwningRow.Cells[8].Value.ToString();
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
            string employeeName = txtKeyWord.Text;
            string sex = txtKeyWord.Text;
            string employeeDepartment = txtKeyWord.Text;
            string employeePost = txtKeyWord.Text;
            switch(strSelect)
            {
                case "员工姓名":
                    {
                        strWhere = strWhere + " and EmployeeName like '%" + employeeName + "%'";
                    }
                    break;
                case "员工性别":
                    {
                        strWhere = strWhere + " and Sex = '" + sex + "'";
                    }
                    break;
                case "所属部门":
                    {
                        strWhere = strWhere + " and EmployeeDepartment like '" + employeeDepartment + "'";
                    }
                    break;
                case "员工职位":
                    {
                        strWhere = strWhere + " and EmployeePost like '" + employeePost + "'";
                    }
                    break;
            }
            BLL.Employee bll = new BLL.Employee(); //实例化BLL层          
            DataSet ds = new DataSet();
            ds = bll.GetList(strWhere);//执行带参数SQL语句，将结果存在ds中
            dataGridView1.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源
        }

     

    }
}
