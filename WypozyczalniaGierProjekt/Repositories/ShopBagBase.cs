using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaGierProjekt.Repositories
{
    internal class ShopBagBase
    {
        string connectionString;
        SqlConnection connection;

        public ShopBagBase()
        {
            connectionString = "Server=(local)\\SQLEXPRESS; Database=MVVMLoginDb; Integrated Security=true";
            connection = new SqlConnection(connectionString);
        }
    }
}