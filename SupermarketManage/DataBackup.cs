using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupermarketManage
{
    public partial class DataBackup : Form
    {
        public DataBackup()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text != "")
                {
                    getSqlConnection geCon = new getSqlConnection();
                    SqlConnection con = geCon.GetCon();
                    string strBacl = "backup database SUPERMARKET to disk='" + txtPath.Text.Trim() + "\\" + txtName.Text.Trim() + ".bak'";
                    SqlCommand Cmd = new SqlCommand(strBacl, con);
                    if (Cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("数据备份成功！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("数据备份失败！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("请填写备份的正确位置及文件名！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }// end 
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
    }
}
