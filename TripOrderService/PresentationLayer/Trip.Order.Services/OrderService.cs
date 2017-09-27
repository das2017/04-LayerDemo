using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ServiceStack;
using Trip.Order.DTO;
using Trip.Order.Business;

namespace Trip.Order.Services
{
    public class OrderService: Service
    {
        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="request">查询条件</param>
        /// <returns></returns>
        public SearchOrderResponse Any(SearchOrderRequest request)
        {
            return BusinessFacade.SearchOrder(request);
        }
    }
}