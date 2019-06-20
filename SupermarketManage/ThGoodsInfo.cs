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
        int flag = 0;//标记   //1.添加  
        private void toolAdd_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            flag = 1;
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
        }

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {
            txtThGoodsID.Text = "";
            txtDepotName.Text = "";
            txtGoodsID.Text = "";
            txtSellID.Text = "";
            cboEmpID.Text = "";
            txtThGoodsName.Text = "";
            numSellGoodsNum.Text = "";
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
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (txtThGoodsID.Text == "" || txtSellID.Text == "" || txtGoodsID.Text == "" || txtSellID.Text == "" || txtThGoodsName.Text == "" || numSellGoodsNum.Text == "" || txtThHasPay.Text == "" || txtThNeedPay.Text == "" || cboEmpID.Text == "")
            {
                MessageBox.Show("请将信息添加完整！");
                return;
            }
            Model.THGoodsInfo model = new Model.THGoodsInfo();//实例化model层
            model.THGoodsID = txtThGoodsID.Text.Trim();
            model.KCID = "";
            model.GoodsID = txtGoodsID.Text.Trim();
            model.SellID = txtSellID.Text.Trim();
            model.EmploayeeID = cboEmpID.Text.Trim();
            model.THGoodsName = txtThGoodsName.Text.Trim();
            model.THGoodsNum = int.Parse(numSellGoodsNum.Text.Trim());
            model.THGoodsTime = DateTime.Parse(daThGoodsTime.Value.ToString());
            model.THGoodsPrice = float.Parse(txtThGoodsPrice.Text.Trim());
            model.THNeedPay = float.Parse(txtThNeedPay.Text.Trim());
            model.THHasPay = float.Parse(txtThHasPay.Text.Trim());
            model.THGoodsResult = txtThGoodsResult.Text;

            BLL.THGoodsInfo bll = new BLL.THGoodsInfo();//实例化BLL层

            Model.KCInfo kcInfo = new Model.KCInfo();
            kcInfo.GoodsID = txtGoodsID.Text.Trim();
            kcInfo.GoodsName = txtThGoodsName.Text.Trim();
            kcInfo.DepotName = txtDepotName.Text.Trim();
            kcInfo.CompanyName = txtCompanyName.Text.Trim();
            string strWhere = " GoodsID = '" + kcInfo.GoodsID + "'";
            BLL.KCInfo bllkcInfo = new BLL.KCInfo();//实例化BLL层
            DataSet ds = new DataSet();
            ds = bllkcInfo.GetList(strWhere);
            int sum = int.Parse(ds.Tables[0].Rows[0]["商品数量"].ToString());
            kcInfo.GoodsNum = sum + int.Parse(numSellGoodsNum.Value.ToString());
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
                        if (!bllkcInfo.Update(kcInfo))
                            MessageBox.Show("未能够把数据添加到仓库中");
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
            BLL.Employee bll = new BLL.Employee();
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            if (ds.Tables[0].Rows.Count > 0)
            {
                string[] array = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    array[i] = ds.Tables[0].Rows[i]["员工编号"].ToString();
                    cboEmpID.Items.Add(array[i]);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == 1 )
            {
                txtDepotName.Text = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
                txtSellID.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
                txtGoodsID.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
                txtThGoodsName.Text = dataGridView1.CurrentCell.OwningRow.Cells[5].Value.ToString();
                txtThGoodsPrice.Text = dataGridView1.CurrentCell.OwningRow.Cells[8].Value.ToString();
                txtCompanyName.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
            }
        }

        private void numSellGoodsNum_ValueChanged(object sender, EventArgs e)
        {
            if (txtThGoodsPrice.Text == "0")
                return;
            float price = float.Parse(txtThGoodsPrice.Text.Trim());
            float num = float.Parse(numSellGoodsNum.Value.ToString());
            if (txtThGoodsPrice.Text.Trim() != "")
            {
                float sum = price * num;
                txtThHasPay.Text = sum.ToString();
            }
        }
    }
}
