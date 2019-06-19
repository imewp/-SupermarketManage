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
    public partial class KCGoodsFind : Form
    {
        public KCGoodsFind()
        {
            InitializeComponent();
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.KCInfo bll = new BLL.KCInfo();
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dataGridView1.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void KCGoodsFind_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strSelect = this.cboQuery.Text.Trim();
            if (strSelect == "")
            {
                MessageBox.Show("请选择查询条件！");
                return;
            }
            if (this.txtContent.Text == "")
            {
                MessageBox.Show("输入查询条件！");
                return;
            }
            //商品编号
            //商品名称
            string strWhere = "1=1";
            string goodsID = txtContent.Text;
            string goodsName = txtContent.Text;
            switch (strSelect)
            {
                case "商品编号":
                    {
                        strWhere = strWhere + " and GoodsID like '%" + goodsID + "%'";
                    }
                    break;
                case "商品名称":
                    {
                        strWhere = strWhere + " and GoodsName like '%" + goodsName + "%'";
                    }
                    break;
            }
            BLL.KCInfo bll = new BLL.KCInfo(); //实例化BLL层          
            DataSet ds = new DataSet();
            ds = bll.GetList(strWhere);//执行带参数SQL语句，将结果存在ds中
            dataGridView1.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源
        }
    }
}
