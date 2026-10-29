using Microsoft.Data.SqlClient;
using Huzyon.Library.Models;
using System.Collections.Generic;
using System.Data;

namespace Huzyon.Library.DAL
{
    public class CustomerDAL
    {
        private readonly string connectionString = DbConfig.ConnectionString;

        public List<Customer> GetAllCustomers()
        {
            var customers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID, Name, Email FROM Customer_Table";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(new Customer
                    {
                        CustomerID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2)
                    });
                }
            }

            return customers;
        }
    }
}
