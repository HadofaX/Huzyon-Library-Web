using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Huzyon.Library.Models;

namespace Huzyon.Library.DAL
{
    public class OrderDAL
    {
        private readonly string connectionString = DbConfig.ConnectionString;

        public List<Order> GetAllOrders()
        {
            var orders = new List<Order>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT OrderID, CustomerID, OrderDate FROM Order_Table";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderID = reader.GetInt32(0),
                        CustomerID = reader.GetInt32(1),
                        OrderDate = reader.GetDateTime(2)
                    });
                }
            }

            return orders;
        }
    }
}
