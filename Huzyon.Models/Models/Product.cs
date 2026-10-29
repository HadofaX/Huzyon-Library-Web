using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Huzyon.Library.DAL;
using Huzyon.Library.Models;

namespace Huzyon.Library.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
