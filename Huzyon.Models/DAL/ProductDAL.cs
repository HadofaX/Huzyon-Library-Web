using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Huzyon.Library.Models;
using Huzyon.Library.DAL;

namespace Huzyon.Library.DAL
{
    public class ProductDAL
    {
        private readonly string connectionString = DbConfig.ConnectionString;

        public List<Product> GetAllProducts()
        {

            var products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, Name, Price, AddedDate FROM Product_Table";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var product = new Product
                    {
                        ProductID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDecimal(2),
                        AddedDate = reader.GetDateTime(3)
                    };
                    products.Add(product);
                }
            }

            return products;
        }
    }
}
