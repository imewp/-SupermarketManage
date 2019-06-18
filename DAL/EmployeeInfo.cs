using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class EmployeeInfo
    {
           /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.EmployeeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into EmployeeInfo(");
            strSql.Append("EmployeeID,EmployeeName,Sex,EmployeeBirthday,EmployeeDepartment,EmployeePost,EmployeePhone,EmployeeEmail,EmployeeAddress,EmployeeFlag)");
            strSql.Append(" values (");
            strSql.Append("@EmployeeID,@EmployeeName,@Sex,@EmployeeBirthday,@EmployeeDepartment,@EmployeePost,@EmployeePhone,@EmployeeEmail,@EmployeeAddress,@EmployeeFlag)");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeBirthday", SqlDbType.DateTime),
					new SqlParameter("@EmployeeDepartment", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeePost",SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeePhone", SqlDbType.NVarChar,20),
					new SqlParameter("@EmployeeEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@EmployeeFlag", SqlDbType.Int)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.EmployeeName;
            parameters[2].Value = model.Sex;
            parameters[3].Value = model.EmployeeBirthday;
            parameters[4].Value = model.EmployeeDepartment;
            parameters[5].Value = model.EmployeePost;
            parameters[6].Value = model.EmployeePhone;
            parameters[7].Value = model.EmployeeEmail;
            parameters[8].Value = model.EmployeeAddress;
            parameters[9].Value = model.EmployFalg;

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
        public bool Update(Model.EmployeeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Employee set ");
            strSql.Append("EmployeeName=@EmployeeName,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("EmployeeBirthday=@EmployeeBirthday,");
            strSql.Append("EmployeeDepartment=@EmployeeDepartment,");
            strSql.Append("EmployeePost=@EmployeePost,");
            strSql.Append("EmployeePhone=@EmployeePhone,");
            strSql.Append("EmployeeEmail=@EmployeeEmail,");
            strSql.Append("EmployeeAddress=@EmployeeAddress,");
            strSql.Append("EmployeeFlag=@EmployeeFlag");
            strSql.Append(" where EmployeeID=@EmployeeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeBirthday", SqlDbType.DateTime),
					new SqlParameter("@EmployeeDepartment", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeePost",SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeePhone", SqlDbType.NVarChar,20),
					new SqlParameter("@EmployeeEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@EmployeeFlag", SqlDbType.Int)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.EmployeeName;
            parameters[2].Value = model.Sex;
            parameters[3].Value = model.EmployeeBirthday;
            parameters[4].Value = model.EmployeeDepartment;
            parameters[5].Value = model.EmployeePost;
            parameters[6].Value = model.EmployeePhone;
            parameters[7].Value = model.EmployeeEmail;
            parameters[8].Value = model.EmployeeAddress;
            parameters[9].Value = model.EmployFalg;

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
            strSql.Append("select EmployeeID,EmployeeName,Sex,EmployeeBirthday,EmployeeDepartment,EmployeePost,EmployeePhone,EmployeeEmail,EmployeeAddress,EmployeeFlag ");
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
            strSql.Append("select EmployeeID,EmployeeName,Sex,EmployeeBirthday,EmployeeDepartment,EmployeePost,EmployeePhone,EmployeeEmail,EmployeeAddress,EmployeeFlag ");
            strSql.Append(" FROM EmployeeInfo");
            return DBHelper.SelectToDS(strSql.ToString(), CommandType.Text);
        }
    }
}
