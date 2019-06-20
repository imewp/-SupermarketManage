using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class THGoodsInfo
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.THGoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into THGoodsInfo(");
            strSql.Append("THGoodsID,KCID,GoodsID,SellID,EmployeeID,THGoodsName,THGoodsNum,THGoodsTime,THGoodsPrice,THNeedPay,THHasPay,ThGoodsResult)");
            strSql.Append(" values (");
            strSql.Append("@THGoodsID,@KCID,@GoodsID,@SellID,@EmployeeID,@THGoodsName,@THGoodsNum,@THGoodsTime,@THGoodsPrice,@THNeedPay,@THHasPay,@ThGoodsResult)");
            SqlParameter[] parameters = {
					new SqlParameter("@THGoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@KCID", SqlDbType.NVarChar,50),
                    new SqlParameter("@GoodsID",SqlDbType.NVarChar,50),
					new SqlParameter("@SellID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID",SqlDbType.NVarChar,50),
					new SqlParameter("@THGoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@THGoodsNum", SqlDbType.Int),
                    new SqlParameter("@THGoodsTime", SqlDbType.DateTime),
                    new SqlParameter("@THGoodsPrice", SqlDbType.Float),
                    new SqlParameter("@THNeedPay", SqlDbType.Float),
                    new SqlParameter("@THHasPay", SqlDbType.Float),
                    new SqlParameter("@ThGoodsResult", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.THGoodsID;
            parameters[1].Value = model.KCID;
            parameters[2].Value = model.GoodsID;
            parameters[3].Value = model.SellID;
            parameters[4].Value = model.EmploayeeID;
            parameters[5].Value = model.THGoodsName;
            parameters[6].Value = model.THGoodsNum;
            parameters[7].Value = model.THGoodsTime;
            parameters[8].Value = model.THGoodsPrice;
            parameters[9].Value = model.THNeedPay;
            parameters[10].Value = model.THHasPay;
            parameters[11].Value = model.THGoodsResult;

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
        public bool Update(Model.THGoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update THGoodsInfo set ");
            strSql.Append("KCID=@KCID,");
            strSql.Append("GoodsID=@GoodsID,");
            strSql.Append("SellID=@SellID,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("THGoodsName=@THGoodsName,");
            strSql.Append("THGoodsNum=@THGoodsNum,");
            strSql.Append("THGoodsTime=@THGoodsTime,");
            strSql.Append("THGoodsPrice=@THGoodsPrice,");
            strSql.Append("THNeedPay=@THNeedPay,");
            strSql.Append("THHasPay=@THHasPay,");
            strSql.Append("ThGoodsResult=@ThGoodsResult ");
            strSql.Append(" where THGoodsID=@THGoodsID ");
            SqlParameter[] parameters = {
					new SqlParameter("@THGoodsID", SqlDbType.NVarChar,50),
					new SqlParameter("@KCID", SqlDbType.NVarChar,50),
                    new SqlParameter("@GoodsID",SqlDbType.NVarChar,50),
					new SqlParameter("@SellID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID",SqlDbType.NVarChar,50),
					new SqlParameter("@THGoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@THGoodsNum", SqlDbType.Int),
                    new SqlParameter("@THGoodsTime", SqlDbType.DateTime),
                    new SqlParameter("@THGoodsPrice", SqlDbType.Float),
                    new SqlParameter("@THNeedPay", SqlDbType.Float),
                    new SqlParameter("@THHasPay", SqlDbType.Float),
                    new SqlParameter("@ThGoodsResult", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.THGoodsID;
            parameters[1].Value = model.KCID;
            parameters[2].Value = model.GoodsID;
            parameters[3].Value = model.SellID;
            parameters[4].Value = model.EmploayeeID;
            parameters[5].Value = model.THGoodsName;
            parameters[6].Value = model.THGoodsNum;
            parameters[7].Value = model.THGoodsTime;
            parameters[8].Value = model.THGoodsPrice;
            parameters[9].Value = model.THNeedPay;
            parameters[10].Value = model.THHasPay;
            parameters[11].Value = model.THGoodsResult;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.THGoodsInfo model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from THGoodsInfo ");
            strSql.Append(" where THGoodsID=@THGoodsID ");
            SqlParameter[] parameters = {
					new SqlParameter("@THGoodsID", SqlDbType.NVarChar,50)
                                        };
            parameters[0].Value = model.GoodsID;

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
            strSql.Append("select THGoodsID as 退货编号,KCID as 仓库编号,GoodsID as 销售编号,SellID as 商品编号,EmployeeID as 员工编号,THGoodsName as 商品名称,THGoodsNum as 退货数量,THGoodsTime as 退货时间,THGoodsPrice as 退货单价,THNeedPay as 应付金额,THHasPay as 实付金额,ThGoodsResult as 备注 from THGoodsInfo");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select THGoodsID as 退货编号,KCID as 仓库编号,GoodsID as 销售编号,SellID as 商品编号,EmployeeID as 员工编号,THGoodsName as 商品名称,THGoodsNum as 退货数量,THGoodsTime as 退货时间,THGoodsPrice as 退货单价,THNeedPay as 应付金额,THHasPay as 实付金额,ThGoodsResult as 备注 from THGoodsInfo");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
