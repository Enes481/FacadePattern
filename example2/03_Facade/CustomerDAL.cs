using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Facade
{
    internal class CustomerDAL
    {
        public void Add(Customer customer)
        {
            DbManager dbManager = DbManager.GetDbManager("Server=.;Database=MyDB;Trusted_Connection=True");
            dbManager.Execute("INSERT INTO Customers");
        }
    }
}
