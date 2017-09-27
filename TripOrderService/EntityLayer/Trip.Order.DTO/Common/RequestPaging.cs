using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Trip.Order.DTO
{
    /// <summary>
    /// 分页数据请求类
    /// </summary>
    public class RequestPaging: RequestBase
    {
        public RequestPaging()
        {
            PageSize = 1;
            PageIndex = 1;
        }

        /// <summary>
        /// 每页最多记录数
        /// </summary>        
        public int PageSize { get; set; }

        /// <summary>
        /// 页索引
        /// </summary>        
        public int PageIndex { get; set; }

    }
}
