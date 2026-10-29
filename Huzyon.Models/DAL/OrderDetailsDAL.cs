using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Huzyon.Library.Models;

namespace Huzyon.Library.DAL
{
    public class OrderDetailsDAL
    {
        private readonly string connectionString = DbConfig.ConnectionString;

        public List<OrderDetails> GetAllOrderDetails()
        {
            var list = new List<OrderDetails>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT OrderID, ProductID, Quantity FROM OrderDetails_Table";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new OrderDetails
                    {
                        OrderID = reader.GetInt32(0),
                        ProductID = reader.GetInt32(1),
                        Quantity = reader.GetInt32(2)
                    });
                }
            }

            return list;
        }
    }
}
