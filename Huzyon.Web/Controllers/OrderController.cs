using Microsoft.AspNetCore.Mvc;
using Huzyon.Library.Models;
using Huzyon.Library.DAL;
using System.Collections.Generic;

namespace Huzyon.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderDAL orderDAL;

        public OrderController()
        {
            orderDAL = new OrderDAL();
        }

        public IActionResult Index()
        {
            List<Order> orders = orderDAL.GetAllOrders();
            return View(orders);
        }
    }
}
