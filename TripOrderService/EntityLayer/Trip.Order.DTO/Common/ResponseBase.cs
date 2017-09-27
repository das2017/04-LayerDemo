using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;

namespace Trip.Order.DTO
{
    /// <summary>
    /// 响应DTO实体类的基类
    /// </summary>  
    public class ResponseBase
    {
        public ResponseBase()
        {
            ErrorCode = 200;
            ErrorMsg = "成功响应";
        }

        /// <summary>
        /// 返回编码，200之外的值都表示有错误
        /// </summary>     
        [ApiMember(Name = "ErrorCode", Description = "返回编码，200之外的值都表示有错误", IsRequired = false)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 返回的消息
        /// </summary>     
        [ApiMember(Name = "ErrorMsg", Description = "返回的消息", IsRequired = false)]
        public string ErrorMsg { get; set; }
    }
}
