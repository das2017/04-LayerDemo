using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Trip.Order.Utility
{
    public static class AppSetting
    {
        public readonly static string AppID = ConfigurationManager.AppSettings["AppID"];
        public readonly static string EncryptKey = ConfigurationManager.AppSettings["EncryptKey"];
    }
}
