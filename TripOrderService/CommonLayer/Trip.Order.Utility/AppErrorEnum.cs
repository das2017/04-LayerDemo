using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Order.Utility
{
    public enum AppErrorEnum
    {
        /// <summary>
        /// 成功
        /// </summary>
        [AppErrorEnum("成功")]
        Success = 200,
        /// <summary>
        /// 请求要求身份验证
        /// </summary>
        [AppErrorEnum("请求要求身份验证")]
        UnAuthorized = 401,
        /// <summary>
        /// 服务器内部错误
        /// </summary>
        [AppErrorEnum("服务器内部错误")]
        InternalServerError = 500,

        /// <summary>
        /// 已下单出现价格变动
        /// </summary>
        [AppErrorEnum("已下单出现价格变动")]
        OrderCreateChangePrice = 901,
        /// <summary>
        /// 验舱失败
        /// </summary>
        [AppErrorEnum("验舱失败")]
        CheckClassFailed = 902
    }

}
