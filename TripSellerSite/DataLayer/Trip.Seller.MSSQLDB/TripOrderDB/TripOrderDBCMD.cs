using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Dapper;
using Trip.Seller.Entity;
using Trip.Seller.MSSQLDB;

namespace Trip.Seller.MSSQLDB
{
    public static class TripOrderDBCMD
    {
        public static int CreateOrder(OrderEntity entity)
        {
            return 1;
        }
    }
}
