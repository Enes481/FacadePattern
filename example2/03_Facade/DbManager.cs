using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Facade
{
    internal class DbManager
    {
        SqlConnection connection;
        SqlCommand command;

        static DbManager dbManager;

        private DbManager(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            command = connection.CreateCommand();
        }

        public static DbManager GetDbManager(string connectionString)
        {
            if (dbManager == null)
            {
                dbManager = new DbManager(connectionString);
            }

            return dbManager;
        }

        public void Execute(string query)
        {
            command.CommandText = query;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
