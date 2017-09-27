using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Trip.Seller.Utility
{
    public static class AppSetting
    {
        public readonly static string EncryptKey = ConfigurationManager.AppSettings["EncryptKey"];  
        public readonly static string OrderServiceURL = ConfigurationManager.AppSettings["OrderServiceURL"];        
        public readonly static string StaticFileVersion = ConfigurationManager.AppSettings["StaticFileVersion"];
    }
}
