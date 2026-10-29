using System.Diagnostics;
using Huzyon.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Huzyon.Library.DAL;

namespace Huzyon.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DashboardDAL _dashboardDAL;


    public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _dashboardDAL = new DashboardDAL();
        }

        public IActionResult Index()
        {
            var dashboard = new DashboardViewModel
            {
                TotalProducts = _dashboardDAL.GetTotalProducts(),
                TotalCustomers = _dashboardDAL.GetTotalCustomers(),
                TotalOrders = _dashboardDAL.GetTotalOrders(),
                TotalCategories = _dashboardDAL.GetTotalCategories(),
                TotalFavorites = _dashboardDAL.GetTotalFavorites(),
                TotalOrderDetails = _dashboardDAL.GetTotalOrderDetails(),
                TotalProductCategories = _dashboardDAL.GetTotalProductCategories(),
                ProductsByCategory = _dashboardDAL.GetProductsByCategory()
            };

            return View(dashboard);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }


}
