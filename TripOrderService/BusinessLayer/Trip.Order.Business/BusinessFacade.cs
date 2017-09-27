using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trip.Order.DTO;
using Trip.Order.Utility;

namespace Trip.Order.Business
{
    public static class BusinessFacade
    {
        private static readonly OrderLogic orderLogic = new OrderLogic();

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="request">查询条件</param>
        /// <returns></returns>
        public static SearchOrderResponse SearchOrder(SearchOrderRequest request)
        {
            SearchOrderResponse response = new SearchOrderResponse();
            try
            {
                response = orderLogic.SearchOrder(request);
            }
            catch (AppException ex)
            {
                response.ErrorCode = ex.Code;
                response.ErrorMsg = ex.Message;
            }
            catch
            {
                response.ErrorCode = (int)AppErrorEnum.InternalServerError;
                response.ErrorMsg = EnumHelper.GetDisplay(AppErrorEnum.InternalServerError);
            }
            return response;
        }
    }
}
