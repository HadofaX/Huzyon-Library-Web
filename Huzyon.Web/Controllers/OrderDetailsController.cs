using Microsoft.AspNetCore.Mvc;
using Huzyon.Library.Models;
using Huzyon.Library.DAL;
using System.Collections.Generic;


namespace Huzyon.Web.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly OrderDetailsDAL dal;

        public OrderDetailsController()
        {
            dal = new OrderDetailsDAL();
        }

        public IActionResult Index()
        {
            List<OrderDetails> data = dal.GetAllOrderDetails();
            return View(data);
        }
    }
}
