using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Seller.ViewModel
{
    /// <summary>
    /// 查找订单的请求参数
    /// </summary>   
    public class SearchOrderInput
    {
        /// <summary>
        /// 订单ID号
        /// </summary>
        public int OrderID { get; set; }
    }
}
