using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Dapper;
using Trip.Seller.Entity;

namespace Trip.Seller.MSSQLDB
{
    public static class TripOrderDBQuery
    {
        public static OrderEntity SearchOrder(int orderId)
        {
            const string sql =
@"SELECT OrderID, OrderStateID, Amount, ProductID, ProductName, MemberID, MemberName, OrderCreatedTime
  FROM dbo.[Order] WITH(NOLOCK)
  WHERE OrderID = @OrderID";

            using (var connection = new SqlConnection(ConnectionString.TripOrderDB_SELECT))
            {
                connection.Open();
                return connection.QuerySingleOrDefault<OrderEntity>(sql, new { OrderID = orderId });
            }
        }
    }
}
