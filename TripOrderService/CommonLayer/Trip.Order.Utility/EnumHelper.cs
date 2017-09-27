using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Order.Utility
{
    public class EnumHelper
    {
        private static readonly Dictionary<string, string> _Displays = new Dictionary<string, string>();

        /// <summary>
        /// 获取枚举的Display
        /// </summary>
        /// <param name="value"></param>
        /// <param name="formatter"></param>
        /// <returns></returns>
        public static string GetDisplay(Enum value, params string[] formatter)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            var display = string.Empty;
            if (_Displays.TryGetValue(name, out display) == false)
            {
                var field = type.GetField(name);
                if (field == null) { display = name; }
                else
                {
                    var attribute = Attribute.GetCustomAttribute(field, typeof(AppErrorEnumAttribute)) as AppErrorEnumAttribute;
                    display = attribute == null ? name : attribute.Display;
                }
                _Displays.Add(name, display);
            }

            return (formatter == null || formatter.Length == 0) ? display : string.Format(display, formatter);
        }
    }
}
