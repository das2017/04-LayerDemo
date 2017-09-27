using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trip.Seller.Entity;
using Trip.Order.DTO;
using Trip.Seller.ViewModel;
using Trip.Seller.Utility;
using Trip.Seller.MSSQLDB;
using Trip.Seller.WSAgent;

namespace Trip.Seller.Business
{
    public static class OrderLogic
    {
        public static int CreateOrder(CreateOrderInput input)
        {
            OrderEntity orderEntity = ConvertHelper<CreateOrderInput, OrderEntity>.Convert(input);
            return TripOrderDBFacade.CreateOrder(orderEntity);
        } 
        public static SearchOrderOutput SearchOrder(int orderId)
        {
            OrderEntity result = TripOrderDBQuery.SearchOrder(orderId);
            return ConvertHelper<OrderEntity, SearchOrderOutput>.Convert(result);
        }
    }
}
