using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Trip.Order.DTO;
using Dapper;

namespace Trip.Order.MSSQLDB
{
    public class TripOrderDBQuery
    {
        internal SearchOrderResponse SearchOrder(SearchOrderRequest request)
        {
            const string sql =
@"SELECT OrderID, OrderStateID, Amount, ProductID, ProductName, MemberID, MemberName, OrderCreatedTime
  FROM dbo.[Order] WITH(NOLOCK)
  WHERE OrderID = @OrderID";

            using (var connection = new SqlConnection(ConnectionString.TripOrderDB_SELECT))
            {
                connection.Open();
                return connection.QuerySingleOrDefault<SearchOrderResponse>(sql, new { OrderID = request.OrderID });
            }
        }
    }
}
