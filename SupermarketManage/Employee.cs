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
        
        int flag = 0;   //1.添加  2.修改 3.删除
        private void toolAdd_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            flag = 1;
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
                            }
                            else
                            {
                                MessageBox.Show("数据添加失败");
                            }
                        } break;
                case 2: ; break;
                case 3: ; break;
            }
        }
    }
}
