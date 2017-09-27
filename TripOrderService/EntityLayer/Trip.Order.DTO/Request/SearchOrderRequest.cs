using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;

namespace Trip.Order.DTO
{
    /// <summary>
    /// 请求参数DTO实体类
    /// </summary>   
    /// 
    public class SearchOrderRequest : RequestBase, IReturn<SearchOrderResponse>
    {
        [ApiMember(Name = "OrderID", Description = "订单ID号", IsRequired = true)]
        public int OrderID { get; set; }

        [ApiMember(Name = "OrderStateID", Description = "订单状态", IsRequired = false)]
        public int OrderStateID { get; set; }

        [ApiMember(Name = "MemberID", Description = "会员编号", IsRequired = false)]
        public int MemberID { get; set; }

        [ApiMember(Name = "MemberName", Description = "会员名", IsRequired = false)]
        public string MemberName { get; set; }

    }
}
