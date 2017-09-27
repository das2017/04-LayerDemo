using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack;

namespace Trip.Order.DTO
{
    /// <summary>
    /// 响应DTO实体类
    /// </summary>   
    public class SearchOrderResponse : ResponseBase
    {
        [ApiMember(Name = "OrderID", Description = "订单ID号", IsRequired = true)]
        public int OrderID { get; set; }

        [ApiMember(Name = "OrderStateID", Description = "订单状态", IsRequired = false)]
        public int OrderStateID { get; set; }

        [ApiMember(Name = "Amount", Description = "订单金额", IsRequired = false)]
        public decimal Amount { get; set; }

        [ApiMember(Name = "ProductID", Description = "产品编号", IsRequired = false)]
        public int ProductID { get; set; }

        [ApiMember(Name = "ProductName", Description = "产品名称", IsRequired = false)]
        public string PrductName { get; set; }

        [ApiMember(Name = "MemberID", Description = "会员编号", IsRequired = false)]
        public int MemberID { get; set; }

        [ApiMember(Name = "MemberName", Description = "会员名", IsRequired = false)]
        public string MemberName { get; set; }

        [ApiMember(Name = "OrderCreatedTime", Description = "下单时间", IsRequired = false)]
        public DateTime OrderCreatedTime { get; set; }
    }    
}
