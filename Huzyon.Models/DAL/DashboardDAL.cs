using Microsoft.Data.SqlClient;

namespace Huzyon.Library.DAL
{
    public class DashboardDAL
    {
        private readonly string connectionString = DbConfig.ConnectionString;


    public int GetTotalProducts()
        {
            return GetCount("Product_Table");
        }

        public int GetTotalCustomers()
        {
            return GetCount("Customer_Table");
        }

        public int GetTotalOrders()
        {
            return GetCount("Order_Table");
        }

        public int GetTotalCategories()
        {
            return GetCount("Category_Table");
        }

        public int GetTotalFavorites()
        {
            return GetCount("Favorite_Table");
        }

        public int GetTotalOrderDetails()
        {
            return GetCount("OrderDetails_Table");
        }

        public int GetTotalProductCategories()
        {
            return GetCount("ProductCategory_Table");
        }

        private int GetCount(string tableName)
        {
            string[] allowedTables =
            {
            "Product_Table",
            "Customer_Table",
            "Order_Table",
            "Category_Table",
            "Favorite_Table",
            "OrderDetails_Table",
            "ProductCategory_Table"
        };

            if (!allowedTables.Contains(tableName))
            {
                throw new ArgumentException("Invalid table name.", nameof(tableName));
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT COUNT(*) FROM dbo.[{tableName}]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public List<Huzyon.Library.Models.CategoryProductCount> GetProductsByCategory()
        {
            var results = new List<Huzyon.Library.Models.CategoryProductCount>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT
                c.CategoryName,
                COUNT(pc.ProductID) AS ProductCount
            FROM dbo.Category_Table c
            LEFT JOIN dbo.ProductCategory_Table pc
                ON c.CategoryID = pc.CategoryID
            GROUP BY c.CategoryID, c.CategoryName
            ORDER BY c.CategoryName;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new Huzyon.Library.Models.CategoryProductCount
                            {
                                CategoryName = reader.GetString(0),
                                ProductCount = reader.GetInt32(1)
                            });
                        }
                    }
                }
            }

            return results;
        }
    }

}

