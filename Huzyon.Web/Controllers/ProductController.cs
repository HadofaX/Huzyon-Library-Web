using Microsoft.AspNetCore.Mvc;
using Huzyon.Library.DAL;
using Huzyon.Library.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace Huzyon.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDAL productDAL;
        public ProductController()
        {
            productDAL = new ProductDAL();

        }
        public IActionResult Index()
        {
            List<Product> products = productDAL.GetAllProducts();
            return View(products);


        }
    }
}
