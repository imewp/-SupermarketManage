﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class SellGoodsInfo
    {
        private readonly DAL.SellGoodsInfo dal = new DAL.SellGoodsInfo();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.SellGoodsInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.SellGoodsInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Model.SellGoodsInfo model)
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