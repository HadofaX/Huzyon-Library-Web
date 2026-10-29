using Microsoft.AspNetCore.Mvc;
using Huzyon.Library.Models;
using Huzyon.Library.DAL;
using System.Collections.Generic;

namespace Huzyon.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryDAL categoryDAL;

        public CategoryController()
        {
            categoryDAL = new CategoryDAL();
        }

        public IActionResult Index()
        {
            List<Category> categories = categoryDAL.GetAllCategories();
            return View(categories);
        }
    }
}
