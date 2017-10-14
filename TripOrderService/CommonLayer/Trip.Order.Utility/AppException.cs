using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Order.Utility
{
    public class AppException : ApplicationException
    {
        public int Code { get; private set; }
        public new string Message { get; private set; }

        public AppException(AppErrorEnum errorCode)
        {
            Code = (int)errorCode;
            Message = EnumHelper.GetEnumDescription(errorCode);
        }
    }
}
