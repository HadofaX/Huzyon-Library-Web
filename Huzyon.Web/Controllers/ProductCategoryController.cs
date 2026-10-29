using Microsoft.AspNetCore.Mvc;
using Huzyon.Library.DAL;
using Huzyon.Library.Models;
using System.Collections.Generic;

namespace Huzyon.Web.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly ProductCategoryDAL productCategoryDAL;

        public ProductCategoryController()
        {
            productCategoryDAL = new ProductCategoryDAL();
        }

        public IActionResult Index()
        {
            List<ProductCategory> list = productCategoryDAL.GetAllProductCategories();
            return View(list);
        }
    }
}
