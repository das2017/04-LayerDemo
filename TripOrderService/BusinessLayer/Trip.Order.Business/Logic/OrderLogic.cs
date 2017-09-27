using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trip.Order.DTO;
using Trip.Order.MSSQLDB;

namespace Trip.Order.Business
{
    public class OrderLogic
    {
        internal SearchOrderResponse SearchOrder(SearchOrderRequest request)
        {
            return TripOrderDBFacade.SearchOrder(request);
        }
    }
}
