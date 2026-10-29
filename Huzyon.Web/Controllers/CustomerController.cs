using Microsoft.AspNetCore.Mvc;
using Huzyon.Library.Models;
using Huzyon.Library.DAL;
using System.Collections.Generic;

namespace Huzyon.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDAL customerDAL;

        public CustomerController()
        {
            customerDAL = new CustomerDAL();
        }

        public IActionResult Index()
        {
            List<Customer> customers = customerDAL.GetAllCustomers();
            return View(customers);
        }
    }
}
