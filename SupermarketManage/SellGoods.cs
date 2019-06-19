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
    public partial class SellGoods : Form
    {
        public SellGoods()
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
            txtSellID.ReadOnly = true;
            flag = 2;
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            txtSellID.ReadOnly = false;
        }

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {
            txtSellID.Text = "";
            txtKCID.Text = "";
            txtGoodsID.Text = "";
            txtEmpID.Text = "";
            txtGoodsName.Text = "";
            numSellGoodsNum.Value = 0;
            this.DaSellGoodsTime.Value = DateTime.Now;
            txtdeSellPrice.Text = "";
            txtSellNeedPay.Text = "";
            txtdeSellHasPay.Text = "";
            txtSellRemark.Text = "";
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
            if (txtSellID.Text == "" || txtKCID.Text == "" || txtGoodsID.Text == "" || txtEmpID.Text == "" || txtGoodsName.Text == "" || txtdeSellPrice.Text == "" || txtSellNeedPay.Text == "" || txtdeSellHasPay.Text == "" || txtSellRemark.Text == "")
            {
                MessageBox.Show("请将信息添加完整！");
                return;
            }
            Model.SellGoodsInfo model = new Model.SellGoodsInfo();//实例化model层
            model.SellID = txtSellID.Text.Trim();
            model.KcID = txtKCID.Text.Trim();
            model.GoodsID = txtGoodsID.Text.Trim();
            model.EmployeeID = txtEmpID.Text.Trim();
            model.GoodsName = txtGoodsName.Text.Trim();
            model.SellGoodsNum = int.Parse(numSellGoodsNum.Value.ToString());
            model.SellGoodsTime = DateTime.Parse(this.DaSellGoodsTime.Text);
            model.SellPrice = txtdeSellPrice.Text.Trim();
            model.SellNeedPay = txtSellNeedPay.Text.Trim();
            model.SellHasPay = txtdeSellHasPay.Text.Trim();
            model.SellRemark = txtSellRemark.Text.Trim(); 
            BLL.SellGoodsInfo bll = new BLL.SellGoodsInfo();//实例化BLL层
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


        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.SellGoodsInfo bll = new BLL.SellGoodsInfo();
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
                txtSellID.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
                txtKCID.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
                txtGoodsID.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
                txtEmpID.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
                txtGoodsName.Text = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
                numSellGoodsNum.Value = decimal.Parse(dataGridView1.CurrentCell.OwningRow.Cells[5].Value.ToString());
                DaSellGoodsTime.Text = dataGridView1.CurrentCell.OwningRow.Cells[6].Value.ToString();
                txtdeSellPrice.Text = dataGridView1.CurrentCell.OwningRow.Cells[7].Value.ToString();
                txtSellNeedPay.Text = dataGridView1.CurrentCell.OwningRow.Cells[8].Value.ToString();
                txtdeSellHasPay.Text = dataGridView1.CurrentCell.OwningRow.Cells[9].Value.ToString();
                txtSellRemark.Text = dataGridView1.CurrentCell.OwningRow.Cells[10].Value.ToString();
            }
        }
    }
}
