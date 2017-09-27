using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using Trip.Seller.ViewModel;
using Trip.Seller.Business;

namespace Trip.Seller.MVCSite.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            SearchOrderOutput order = OrderLogic.SearchOrder(1);            
            return View("Order", order);  
        }

        public JsonResult CreateOrder(CreateOrderInput input)
        {
            bool isSuccess = OrderLogic.CreateOrder(input) > 0;
            return Json(isSuccess, JsonRequestBehavior.AllowGet);
        }
    }
}