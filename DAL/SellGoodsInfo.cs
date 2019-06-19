using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class SellGoodsInfo
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.SellGoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SellGoodsInfo(");
            strSql.Append("SellID,KCID,GoodsID,EmployeeID,GoodsName,SellGoodsNum,SellGoodsTime,SellPrice,SellNeedPay,SellHasPay,SellRemark)");
            strSql.Append(" values (");
            strSql.Append("@SellID,@KCID,@GoodsID,@EmployeeID,@GoodsName,@SellGoodsNum,@SellGoodsTime,@SellPrice,@SellNeedPay,@SellHasPay,@SellRemark)");
            SqlParameter[] parameters = {
					new SqlParameter("@SellID", SqlDbType.NVarChar,50),
					new SqlParameter("@KCID", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@SellGoodsNum",SqlDbType.Int),
					new SqlParameter("@SellGoodsTime", SqlDbType.DateTime),
					new SqlParameter("@SellPrice", SqlDbType.Float),
					new SqlParameter("@SellNeedPay", SqlDbType.Float),
                    new SqlParameter("@SellHasPay", SqlDbType.Float),
					new SqlParameter("@SellRemark", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.SellID;
            parameters[1].Value = model.KcID;
            parameters[2].Value = model.GoodsID;
            parameters[3].Value = model.EmployeeID;
            parameters[4].Value = model.GoodsName;
            parameters[5].Value = model.SellGoodsNum;
            parameters[6].Value = model.SellGoodsTime;
            parameters[7].Value = model.SellPrice;
            parameters[8].Value = model.SellNeedPay;
            parameters[9].Value = model.SellHasPay;
            parameters[10].Value = model.SellRemark;

            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.SellGoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SellGoodsInfo set ");
            strSql.Append("KCID=@KCID,");
            strSql.Append("GoodsID=@GoodsID,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("GoodsName=@GoodsName,");
            strSql.Append("SellGoodsNum=@SellGoodsNum,");
            strSql.Append("SellGoodsTime=@SellGoodsTime,");
            strSql.Append("SellPrice=@SellPrice,");
            strSql.Append("SellNeedPay=@SellNeedPay,");
            strSql.Append("SellHasPay=@SellHasPay,");
            strSql.Append("SellRemark=@SellRemark");
            strSql.Append(" where SellID=@SellID ");
            SqlParameter[] parameters = {
					new SqlParameter("@SellID", SqlDbType.NVarChar,50),
					new SqlParameter("@KCID", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@SellGoodsNum",SqlDbType.Int),
					new SqlParameter("@SellGoodsTime", SqlDbType.DateTime),
					new SqlParameter("@SellPrice", SqlDbType.Float),
					new SqlParameter("@SellNeedPay", SqlDbType.Float),
                    new SqlParameter("@SellHasPay", SqlDbType.Float),
					new SqlParameter("@SellRemark", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.SellID;
            parameters[1].Value = model.KcID;
            parameters[2].Value = model.GoodsID;
            parameters[3].Value = model.EmployeeID;
            parameters[4].Value = model.GoodsName;
            parameters[5].Value = model.SellGoodsNum;
            parameters[6].Value = model.SellGoodsTime;
            parameters[7].Value = model.SellPrice;
            parameters[8].Value = model.SellNeedPay;
            parameters[9].Value = model.SellHasPay;
            parameters[10].Value = model.SellRemark;

            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SellID as 销售编号,KCID as 仓库编号,GoodsID as 商品编号,EmployeeID as 员工编号,GoodsName as 商品名称,SellGoodsNum as 销售数量,SellGoodsTime as 销售时间,SellPrice as 销售单价,SellNeedPay as 应付金额,SellHasPay as 实付金额,SellRemark as 备注");
            strSql.Append(" FROM SellGoodsInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.SellGoodsInfo model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SellGoodsInfo ");
            strSql.Append(" where SellID=@SellID ");
            SqlParameter[] parameters = {
					new SqlParameter("@SellID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = model.SellID;

            int rows = DBHelper.ExecuteSql(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select SellID as 销售编号,KCID as 仓库编号,GoodsID as 商品编号,EmployeeID as 员工编号,GoodsName as 商品名称,SellGoodsNum as 销售数量,SellGoodsTime as 销售时间,SellPrice as 销售单价,SellNeedPay as 应付金额,SellHasPay as 实付金额,SellRemark as 备注 ");
            strSql.Append(" FROM SellGoodsInfo");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
