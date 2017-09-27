/* Options:
Date: 2017-09-27 19:17:27
Version: 4.00
Tip: To override a DTO option, remove "//" prefix before updating
BaseUrl: http://localhost:41054

//GlobalNamespace: 
//MakePartial: True
//MakeVirtual: True
//MakeDataContractsExtensible: False
//AddReturnMarker: True
//AddDescriptionAsComments: True
//AddDataContractAttributes: False
//AddIndexesToDataMembers: False
//AddGeneratedCodeAttributes: False
//AddResponseStatus: False
//AddImplicitVersion: 
//InitializeCollections: True
//IncludeTypes: 
//ExcludeTypes: 
//AddDefaultXmlNamespace: http://schemas.servicestack.net/types
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using Trip.Order.DTO;


namespace Trip.Order.DTO
{

    public partial class RequestBase
    {
    }

    public partial class ResponseBase
    {
        ///<summary>
        ///返回编码，200之外的值都表示有错误
        ///</summary>
        [ApiMember(Name="ErrorCode", Description="返回编码，200之外的值都表示有错误")]
        public virtual int ErrorCode { get; set; }

        ///<summary>
        ///返回的消息
        ///</summary>
        [ApiMember(Name="ErrorMsg", Description="返回的消息")]
        public virtual string ErrorMsg { get; set; }
    }

    [Route("/OrderService/SearchOrder", "GET,POST")]
    public partial class SearchOrderRequest
        : RequestBase, IReturn<SearchOrderResponse>
    {
        ///<summary>
        ///订单ID号
        ///</summary>
        [ApiMember(Name="OrderID", Description="订单ID号", IsRequired=true)]
        public virtual int OrderID { get; set; }

        ///<summary>
        ///订单状态
        ///</summary>
        [ApiMember(Name="OrderStateID", Description="订单状态")]
        public virtual int OrderStateID { get; set; }

        ///<summary>
        ///会员编号
        ///</summary>
        [ApiMember(Name="MemberID", Description="会员编号")]
        public virtual int MemberID { get; set; }

        ///<summary>
        ///会员名
        ///</summary>
        [ApiMember(Name="MemberName", Description="会员名")]
        public virtual string MemberName { get; set; }
    }

    public partial class SearchOrderResponse
        : ResponseBase
    {
        ///<summary>
        ///订单ID号
        ///</summary>
        [ApiMember(Name="OrderID", Description="订单ID号", IsRequired=true)]
        public virtual int OrderID { get; set; }

        ///<summary>
        ///订单状态
        ///</summary>
        [ApiMember(Name="OrderStateID", Description="订单状态")]
        public virtual int OrderStateID { get; set; }

        ///<summary>
        ///订单金额
        ///</summary>
        [ApiMember(Name="Amount", Description="订单金额")]
        public virtual decimal Amount { get; set; }

        ///<summary>
        ///产品编号
        ///</summary>
        [ApiMember(Name="ProductID", Description="产品编号")]
        public virtual int ProductID { get; set; }

        ///<summary>
        ///产品名称
        ///</summary>
        [ApiMember(Name="ProductName", Description="产品名称")]
        public virtual string PrductName { get; set; }

        ///<summary>
        ///会员编号
        ///</summary>
        [ApiMember(Name="MemberID", Description="会员编号")]
        public virtual int MemberID { get; set; }

        ///<summary>
        ///会员名
        ///</summary>
        [ApiMember(Name="MemberName", Description="会员名")]
        public virtual string MemberName { get; set; }

        ///<summary>
        ///下单时间
        ///</summary>
        [ApiMember(Name="OrderCreatedTime", Description="下单时间")]
        public virtual DateTime OrderCreatedTime { get; set; }
    }
}

