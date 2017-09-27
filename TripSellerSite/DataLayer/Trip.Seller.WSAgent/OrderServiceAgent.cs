using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trip.Order.DTO;
using Trip.Seller.Utility;
using ServiceStack;

namespace Trip.Seller.WSAgent
{
    public static class OrderServiceAgent
    {
        /// <summary>
        /// 查找订单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static SearchOrderResponse SearchOrder(SearchOrderRequest request)
        {
            using (JsonServiceClient client = new JsonServiceClient(AppSetting.OrderServiceURL))
            {
                return client.Send<SearchOrderResponse>(request);
            }
        }
    }
}
