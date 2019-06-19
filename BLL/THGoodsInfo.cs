using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class THGoodsInfo
    {
        private readonly DAL.THGoodsInfo dal= new DAL.THGoodsInfo();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.THGoodsInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.THGoodsInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.THGoodsInfo model)
        {
            return dal.Delete(model);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 获得数据列表，无参数
        /// </summary>
        public DataSet GetList()
        {
            return dal.GetList();
        }
    }
}
