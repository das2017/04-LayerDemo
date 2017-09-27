using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trip.Seller.Entity;

namespace Trip.Seller.MSSQLDB
{
    public static class TripOrderDBFacade
    {
        /// <summary>
        /// 查找订单
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public static OrderEntity SearchOrder(int orderId)
        {
            return TripOrderDBQuery.SearchOrder(orderId);
        }
       
        /// <summary>
        /// 创建订单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int CreateOrder(OrderEntity entity)
        {
            return TripOrderDBCMD.CreateOrder(entity);
        }
    }
}
