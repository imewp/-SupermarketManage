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
    public partial class ThGoodsInfo : Form
    {
        public ThGoodsInfo()
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
            txtThGoodsID.Text = "";
            txtKCID.Text = "";
            txtGoodsID.Text = "";
            txtSellID.Text = "";
            txtEmpID.Text = "";
            txtThGoodsName.Text = "";
            txThGoodsNum.Text = "";
            daThGoodsTime.Value = DateTime.Now;
            txtThGoodsPrice.Text = "";
            txtThNeedPay.Text = "";
            txtThHasPay.Text = "";
            txtThGoodsResult.Text = "";
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
            if (txtThGoodsID.Text == "" || txtSellID.Text == "" || txtGoodsID.Text == "" || txtSellID.Text == "" || txtEmpID.Text == "" || txtThGoodsName.Text == "" || txThGoodsNum.Text == "" || txtThHasPay.Text == "" || txtThNeedPay.Text == "" || txtThGoodsResult.Text == "" || txtEmpID.Text == "" || txThGoodsNum.Text == "")
            {
                MessageBox.Show("请将信息添加完整！");
                return;
            }
            Model.THGoodsInfo model = new Model.THGoodsInfo();//实例化model层
            model.THGoodsID = txtThGoodsID.Text.Trim();
            model.KCID = txtKCID.Text.Trim();
            model.GoodsID = txtGoodsID.Text.Trim();
            model.SellID = txtSellID.Text.Trim();
            model.EmploayeeID = txtEmpID.Text.Trim();
            model.THGoodsName = txtThGoodsName.Text.Trim();
            model.THGoodsNum = int.Parse(txThGoodsNum.Text.Trim());
            model.THGoodsTime = DateTime.Parse(daThGoodsTime.Value.ToString());
            model.THGoodsPrice = float.Parse(txtThGoodsPrice.Text.Trim());
            model.THNeedPay = float.Parse(txtThNeedPay.Text.Trim());
            model.THHasPay = float.Parse(txtThHasPay.Text.Trim());
            model.THGoodsResult = txtThGoodsResult.Text;

            BLL.THGoodsInfo bll = new BLL.THGoodsInfo();//实例化BLL层
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
            BLL.THGoodsInfo bll = new BLL.THGoodsInfo();
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
                txtThGoodsID.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
                txtKCID.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
                txtGoodsID.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
                txtSellID.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
                txtEmpID.Text = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
                txtThGoodsName.Text = dataGridView1.CurrentCell.OwningRow.Cells[5].Value.ToString();
                txThGoodsNum.Text = dataGridView1.CurrentCell.OwningRow.Cells[6].Value.ToString();
                daThGoodsTime.Text = dataGridView1.CurrentCell.OwningRow.Cells[7].Value.ToString();
                txtThGoodsPrice.Text = dataGridView1.CurrentCell.OwningRow.Cells[8].Value.ToString();
                txtThNeedPay.Text = dataGridView1.CurrentCell.OwningRow.Cells[9].Value.ToString();
                txtThHasPay.Text = dataGridView1.CurrentCell.OwningRow.Cells[10].Value.ToString();
                txtThGoodsResult.Text = dataGridView1.CurrentCell.OwningRow.Cells[11].Value.ToString();
            }
        }
    }
}
