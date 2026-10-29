using System.Collections.Generic;
using Huzyon.Library.Models;

namespace Huzyon.Web.Models
{
    public class DashboardViewModel
    {
        public int TotalProducts { get; set; }

        public int TotalCustomers { get; set; }

        public int TotalOrders { get; set; }

        public int TotalCategories { get; set; }

        public int TotalFavorites { get; set; }

        public int TotalOrderDetails { get; set; }

        public int TotalProductCategories { get; set; }

        public List<CategoryProductCount> ProductsByCategory { get; set; } = new();
    }
}
