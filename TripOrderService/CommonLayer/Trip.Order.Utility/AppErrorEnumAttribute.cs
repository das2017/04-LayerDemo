using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Order.Utility
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class AppErrorEnumAttribute : Attribute
    {
        public string Display { get; private set; }

        public AppErrorEnumAttribute(string display) 
        { 
            Display = display; 
        }
    }
}
