using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    class SellGoodsInfo
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
            strSql.Append("EmployeeName=@EmployeeName,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("EmployeeBirthday=@EmployeeBirthday,");
            strSql.Append("EmployeeDepartment=@EmployeeDepartment,");
            strSql.Append("EmployeePost=@EmployeePost,");
            strSql.Append("EmployeePhone=@EmployeePhone,");
            strSql.Append("EmployeeEmail=@EmployeeEmail,");
            strSql.Append("EmployeeAddress=@EmployeeAddress,");
            strSql.Append("EmployeeFlag=@EmployeeFlag");
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
            strSql.Append("select EmployeeID as 员工编号,EmployeeName as 员工姓名,Sex as 性别,EmployeeBirthday as 出生日期,EmployeeDepartment as 所属部门,EmployeePost as 部门职位,EmployeePhone 联系电话,EmployeeEmail as 电子邮箱,EmployeeAddress 家庭住址");
            strSql.Append(" FROM EmployeeInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.EmployeeInfo model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from EmployeeInfo ");
            strSql.Append(" where EmployeeID=@EmployeeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = model.EmployeeID;

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
            strSql.Append("select EmployeeID as 员工编号,EmployeeName as 员工姓名,Sex as 性别,EmployeeBirthday as 出生日期,EmployeeDepartment as 所属部门,EmployeePost as 部门职位,EmployeePhone 联系电话,EmployeeEmail as 电子邮箱,EmployeeAddress 家庭住址 ");
            strSql.Append(" FROM EmployeeInfo");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
