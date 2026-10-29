using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huzyon.Library.Models
{
    public class Favorite
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public DateTime FavoriteDate { get; set; }
        public decimal Price { get; set; }
        public int FavoriteCount { get; set; }
    }
}
