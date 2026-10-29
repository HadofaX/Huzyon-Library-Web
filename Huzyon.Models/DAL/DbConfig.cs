using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Huzyon.Library.DAL
{
    public class DbConfig
    {
        public static string ConnectionString = "Server=.\\SQLEXPRESS;Initial Catalog=HuzyonSql;Trusted_Connection=True;TrustServerCertificate=True;";

    }
}
