using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Trip.Order.DTO
{
    /// <summary>
    /// 分页数据响应类
    /// </summary>   
    public class ResponsePaging : ResponseBase
    {
        /// <summary>
        /// 每页最多记录数
        /// </summary>        
        public int PageSize { get; set; }

        /// <summary>
        /// 页索引
        /// </summary>        
        public int PageIndex { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>        
        public int RowCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>        
        public int PageCount
        {
            get
            {
                if (PageSize > 0 && RowCount > 0)
                {
                    return RowCount % PageSize == 0 ? (RowCount / PageSize) : (RowCount / PageSize + 1);
                }
                return 0;
            }
        }
    }
}
