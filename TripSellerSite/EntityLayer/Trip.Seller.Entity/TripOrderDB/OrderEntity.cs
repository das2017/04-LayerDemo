using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Seller.Entity
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class OrderEntity
    {
        /// <summary>
        /// 订单ID号
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public int OrderStateID { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 会员编号
        /// </summary>
        public int MemberID { get; set; }

        /// <summary>
        /// 会员名
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime OrderCreatedTime { get; set; }
    }
}
