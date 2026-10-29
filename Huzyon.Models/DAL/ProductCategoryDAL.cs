using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Huzyon.Library.Models;
using Huzyon.Library.DAL;


namespace Huzyon.Library.DAL
{
    public class ProductCategoryDAL
    {
        private readonly string connectionString = DbConfig.ConnectionString;

        public List<ProductCategory> GetAllProductCategories()
        {
            var list = new List<ProductCategory>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, CategoryID FROM ProductCategory_Table";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new ProductCategory
                    {
                        ProductID = reader.GetInt32(0),
                        CategoryID = reader.GetInt32(1)
                    });
                }
            }

            return list;
        }
    }
}
