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
    public partial class UserS : Form
    {
        public UserS()
        {
            InitializeComponent();
        }
        void DataBind()
        {
            BLL.UserInfo bll = new BLL.UserInfo();
            DataSet ds = new DataSet();
            ds = bll.GetList();
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Model.UserInfo model = new Model.UserInfo();
            model.UserName = textBox1.Text.Trim();
            model.UserPassword = textBox2.Text.Trim();
            model.UserType = textBox3.Text;

            BLL.UserInfo bll = new BLL.UserInfo();
            model = bll.ToMD5(model);
            if (bll.Update(model))
            {
                MessageBox.Show("修改成功！");
                DataBind();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentCell.OwningRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentCell.OwningRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.CurrentCell.OwningRow.Cells[2].Value.ToString();
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            Model.UserInfo model = new Model.UserInfo();
            model.UserName = textBox1.Text.Trim();
            model.UserPassword = textBox2.Text.Trim();
            model.UserType = textBox3.Text;

            BLL.UserInfo bll = new BLL.UserInfo();
            model = bll.ToMD5(model);
            if (bll.Add(model))
            {
                MessageBox.Show("添加成功！");
                DataBind();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            Model.UserInfo model = new Model.UserInfo();
            model.UserName = textBox1.Text.Trim();

            BLL.UserInfo bll = new BLL.UserInfo();
            if (bll.Delete(model))
            {
                MessageBox.Show("删除成功！");
                DataBind();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
    }
}
