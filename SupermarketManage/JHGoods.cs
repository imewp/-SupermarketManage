﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupermarketManage
{
    public partial class JHGoods : Form
    {
        public JHGoods()
        {
            InitializeComponent();
        }
        int flag = 0;//标记   //1.添加  2.修改 
        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {

            txtGoodsID.Text = "";
            cboEmployeeID.Text = "";
            cboComName.Text = "";
            cboDepotName.Text = "";
            txtGoodsName.Text = "";
            numGoodsNum.Value = 0;
            cmbGoodsUnit.SelectedIndex = 0;
            txtGoodsJHPrice.Text = "0";
            txtSellGoodsPrice.Text = "0";
            txtGoodsNeedPrice.Text = "0";
            txtGoodsHasPay.Text = "0";
            txtRemarks.Text = "";         
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
            txtGoodsID.ReadOnly = true;
            flag = 2;
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
            txtGoodsID.ReadOnly = false;
            flag = 0;
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (txtGoodsID.Text == "" || txtGoodsName.Text == "" || cboComName.Text == "" || cboDepotName.Text == "")
            {
                MessageBox.Show("请将信息添加完整！");
                return;
            }
            Model.JHGoodsInfo model = new Model.JHGoodsInfo();//实例化model层
            model.GoodsID = txtGoodsID.Text.Trim();
            model.EmployeeID = cboEmployeeID.Text.Trim();
            model.CompanyName = cboComName.Text.Trim();
            model.DepotName = cboDepotName.Text.Trim();
            model.GoodsName = txtGoodsName.Text;
            model.GoodsNum = int.Parse(numGoodsNum.Value.ToString());
            model.GoodsUnit = cmbGoodsUnit.Text.Trim();
            model.GoodsJHPrice = float.Parse(txtGoodsJHPrice.Text.Trim());
            model.GoodsSellPrice = float.Parse(txtSellGoodsPrice.Text.Trim());
            model.GoodsNeedPay = float.Parse(txtGoodsNeedPrice.Text.Trim());
            model.GoodsHasPay = float.Parse(txtGoodsHasPay.Text.Trim());
            model.GoodsRemark = txtRemarks.Text;
            model.GoodsTime = DateTime.Parse(dateTimePicker1.Text);
            BLL.JHGoodsInfo bll = new BLL.JHGoodsInfo();//实例化BLL层
            Model.KCInfo kcInfo = new Model.KCInfo();
            kcInfo.GoodsID = txtGoodsID.Text.Trim();
            kcInfo.GoodsName = txtGoodsName.Text;
            kcInfo.CompanyName = cboComName.Text.Trim();
            kcInfo.DepotName = cboDepotName.Text.Trim();
            kcInfo.GoodsNum = int.Parse(numGoodsNum.Value.ToString());
            BLL.KCInfo bllkcInfo = new BLL.KCInfo();//实例化BLL层
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
                        if (!bllkcInfo.Add(kcInfo))
                            MessageBox.Show("未能够把数据添加到仓库中");
                    } break;
                case 2:
                    {
                        if (bll.Update(model))//根据返回布尔值判断是否修改数据成功
                        {
                            DataBind();//窗体登录时绑定数据到DataGridView
                            ControlStatus();
                        }
                        if (!bllkcInfo.Update(kcInfo))
                            MessageBox.Show("未能够把数据修改到仓库中");
                    } break;
            }
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.JHGoodsInfo bll = new BLL.JHGoodsInfo();
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dataGridView1.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void JHGoods_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
            ObtionEmployeeID(); //获取员工编号
            ObtionCompanyName();//获取供应商名称
        }
        /// <summary>
        /// 获取供应商表中的  供应商名称
        /// </summary>
        private void ObtionCompanyName()
        {
            BLL.CompanyInfo bll = new BLL.CompanyInfo();
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            if (ds.Tables[0].Rows.Count > 0)
            {
                string[] array = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    array[i] = ds.Tables[0].Rows[i]["供应商名称"].ToString();
                    cboComName.Items.Add(array[i]);
                }
            }
        }
        /// <summary>
        /// 获取员工表中的  员工编号
        /// </summary>
        private void ObtionEmployeeID()
        {
            BLL.Employee bll = new BLL.Employee();
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            if (ds.Tables[0].Rows.Count > 0)
            {
                string[] array = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    array[i] = ds.Tables[0].Rows[i]["员工编号"].ToString();
                    cboEmployeeID.Items.Add(array[i]);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == 2 )
            {
                txtGoodsID.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
                cboEmployeeID.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
                cboComName.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
                cboDepotName.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
                txtGoodsName.Text = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
                numGoodsNum.Value = decimal.Parse(dataGridView1.CurrentCell.OwningRow.Cells[5].Value.ToString());
                cmbGoodsUnit.Text = dataGridView1.CurrentCell.OwningRow.Cells[6].Value.ToString();
                txtGoodsJHPrice.Text = dataGridView1.CurrentCell.OwningRow.Cells[7].Value.ToString();
                txtSellGoodsPrice.Text = dataGridView1.CurrentCell.OwningRow.Cells[8].Value.ToString();
                txtGoodsNeedPrice.Text = dataGridView1.CurrentCell.OwningRow.Cells[9].Value.ToString();
                txtGoodsHasPay.Text = dataGridView1.CurrentCell.OwningRow.Cells[10].Value.ToString();
                txtRemarks.Text = dataGridView1.CurrentCell.OwningRow.Cells[11].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentCell.OwningRow.Cells[12].Value.ToString();
            }
        }

        private void txtGoodsJHPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtGoodsJHPrice.Text == "0")
                return;
            float price = float.Parse(txtGoodsJHPrice.Text.Trim());
            float num = float.Parse(numGoodsNum.Value.ToString());
            if (txtGoodsJHPrice.Text.Trim() != "")
            {
                float sum = price * num;
                txtGoodsNeedPrice.Text = sum.ToString();
            }
        }
    }
}