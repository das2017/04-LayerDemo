using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trip.Order.DTO;
using Trip.Order.Entity;

namespace Trip.Order.MSSQLDB
{
    public static class TripOrderDBFacade
    {
        private static readonly TripOrderDBCMD CMD = new TripOrderDBCMD();
        private static readonly TripOrderDBQuery Query = new TripOrderDBQuery();

        /// <summary>
        /// 创建订单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int CreateOrder(OrderEntity entity)
        {
            return CMD.CreateOrder(entity);
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="request">查询条件</param>
        /// <returns></returns>
        public static SearchOrderResponse SearchOrder(SearchOrderRequest request)
        {
            return Query.SearchOrder(request);
        }        
    }
}
