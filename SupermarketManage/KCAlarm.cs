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
    public partial class KCAlarmNum : Form
    {
        public KCAlarmNum()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString();
            txtGoodsName.Text = dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString();
            txtCompanyName.Text = dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString();
            txtDepotName.Text = dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString();
            txtGoodsNum.Text = dataGridView1.CurrentCell.OwningRow.Cells[4].Value.ToString();
        }
        public void DataBind()//定义一个函数用于绑定数据到DataGridView
        {
            BLL.KCInfo bll = new BLL.KCInfo();
            DataSet ds = new DataSet();
            ds = bll.GetList();//执行SQL语句，将结果存在ds中
            dataGridView1.DataSource = ds.Tables[0];//将ds中的表作为DataGridView的数据源   
        }

        private void KCAlarmNum_Load(object sender, EventArgs e)
        {
            DataBind();//窗体登录时绑定数据到DataGridView
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.KCInfo model = new Model.KCInfo();
            model.GoodsID = txtid.Text.Trim();
            model.GoodsName = txtGoodsName.Text.Trim();
            model.CompanyName = txtCompanyName.Text.Trim();
            model.DepotName = txtDepotName.Text.Trim();
            model.GoodsNum = int.Parse(txtGoodsNum.Text.Trim());
            model.AlarmNum = int.Parse(txtAlarmNum.Text.Trim());
            BLL.KCInfo bll = new BLL.KCInfo();
            if (bll.Update(model))//将员工信息添加到数据库中，根据返回值判断是否添加成功
            {
                DataBind();//窗体登录时绑定数据到DataGridView
            }
        }
    }
}
