using System;

namespace _03_Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DbManager dbManager = DbManager.GetDbManager("Server=.;Database=MyDB;Trusted_Connection=True");
            //dbManager.Execute("SELECT * FROM Products");

            CustomerDAL customerDAL = new CustomerDAL();
            customerDAL.Add(new Customer());

            Console.ReadKey();
        }
    }
}
