using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Trip.Seller.Utility;

namespace Trip.Seller.MSSQLDB
{
    /// <summary>
    /// 数据库连接字符串
    /// </summary>
    internal class ConnectionString
    {
        public readonly static string TripOrderDBSelect = ConfigurationManager.ConnectionStrings["TripOrderDB_SELECT"].ConnectionString;
        public readonly static string TripOrderDBInsert = ConfigurationManager.ConnectionStrings["TripOrderDB_INSERT"].ConnectionString;

        /// <summary>
        /// TripOrderDB库只读链接
        /// </summary>
        public static string TripOrderDB_SELECT
        {
            get
            {
                return Encryption.Decrypt(TripOrderDBSelect, AppSetting.EncryptKey);
            }
        }
      
        /// <summary>
        /// TripOrderDB库写链接
        /// </summary>
        public static string TripOrderDB_INSERT
        {
            get
            {
                return Encryption.Decrypt(TripOrderDBInsert, AppSetting.EncryptKey);
            }
        }
    }
}
