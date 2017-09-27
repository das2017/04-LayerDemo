using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Dapper;
using Trip.Order.Entity;

namespace Trip.Order.MSSQLDB
{
    public class TripOrderDBCMD
    {
        internal int CreateOrder(OrderEntity entity)
        {
            const string sql =
@"INSERT INTO dbo.[Order](OrderStateID, Amount, ProductID, ProductName, MemberID, MemberName, OrderCreatedTime) 
VALUES (@OrderStateID, @Amount, @ProductID, @ProductName, @MemberID, @MemberName, @OrderCreatedTime);
SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (var connection = new SqlConnection(ConnectionString.TripOrderDB_INSERT))
            {
                connection.Open();
                return connection.Query<int>(sql, entity).Single();
            }
        }
    }
}
