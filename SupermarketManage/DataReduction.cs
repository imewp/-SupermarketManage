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
    public partial class DataReduction : Form
    {
        public DataReduction()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "txt files (*.bak)|*.bak|All files (*.*)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void btnReduction_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                getSqlConnection geCon = new getSqlConnection();
                SqlConnection con = geCon.GetCon();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                string DateStr = @"Data Source=WP521\WANGPENG;Initial Catalog=master;Integrated Security=True";
                SqlConnection conn = new SqlConnection(DateStr);
                conn.Open();

                //-------------------杀掉所有连接 db_CSManage 数据库的进程--------------
                string strSQL = "select spid from master..sysprocesses where dbid=db_id( 'SUPERMARKET') ";
                SqlDataAdapter Da = new SqlDataAdapter(strSQL, conn);

                DataTable spidTable = new DataTable();
                Da.Fill(spidTable);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = conn;

                for (int iRow = 0; iRow <= spidTable.Rows.Count - 1; iRow++)
                {
                    Cmd.CommandText = "kill " + spidTable.Rows[iRow][0].ToString();   //强行关闭用户进程 
                    Cmd.ExecuteNonQuery();
                }
                conn.Close();
                conn.Dispose();
                //--------------------------------------------------------------------

                SqlConnection sqlcon = new SqlConnection(DateStr);
                sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("backup log SUPERMARKET to disk='" + txtPath.Text.Trim() + "' restore database SUPERMARKET  from disk='" + txtPath.Text.Trim() + "' WITH REPLACE", sqlcon);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
                MessageBox.Show("数据还原成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("为了必免数据丢失，在数据库还原后将关闭整个系统。");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("请选择备份文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public bool RestoreDataBase(string databasename,string databasefile)
       {
           SqlConnection constring = new SqlConnection("Data Source=WP521\\WANGPENG;Initial Catalog=SUPERMARKET;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
           string sql = "RESTORE DATABASE WITH REPLACE" + databasename + " from DISK ='" + databasefile + " '";//数据库名称和路径 WITH REPLACE是去除日志文件
           SqlCommand sqlcmd = new SqlCommand(sql, constring);
           sqlcmd.CommandType = CommandType.Text;
            
           try {
               //开始
               constring.Open();
               sqlcmd.ExecuteNonQuery();
           }catch(Exception ex)
           {
               string str = ex.Message;
               constring.Close();
               return false;
           }
           constring.Close();//结束
           return true;
       }
    }
}
