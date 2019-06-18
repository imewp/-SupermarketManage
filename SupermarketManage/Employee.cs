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
        public int panduan()
        {
            return flag;
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
                                MessageBox.Show("数据添加成功");
                                DataBind();//窗体登录时绑定数据到DataGridView
                                ControlStatus();
                            }
                            else
                            {
                                MessageBox.Show("数据添加失败");
                            }
                        } break;
                case 2: {
                             if (bll.Update(model))//根据返回布尔值判断是否修改数据成功
                            {
                                MessageBox.Show("数据修改成功");
                                DataBind();//窗体登录时绑定数据到DataGridView
                                ControlStatus();
                            }
                            else
                            {
                                MessageBox.Show("数据修改失败");
                            }
                        } break;
                case 3: {
                            if (bll.Delete(model))//根据返回布尔值判断是否删除数据成功
                            {
                                MessageBox.Show("数据删除成功");
                                DataBind();//窗体登录时绑定数据到DataGridView
                                ControlStatus();
                            }
                            else
                            {
                                MessageBox.Show("数据删除失败");
                            }
                        } break;
            }
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            flag = 2;
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

     

    }
}
