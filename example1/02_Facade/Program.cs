using System;

namespace _02_Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Without Facade
            //Customer customer = new Customer("111111");
            //TCKNService tCKNService = new TCKNService();

            //customer.Name = tCKNService.GetInfoByTCKN(customer.TCKN);

            //BlackListService blackListService = new BlackListService();
            //bool result = blackListService.IsBlock(customer.TCKN);

            //if (!result)
            //{
            //    AccountValidation accountValidation = new AccountValidation();
            //    result = accountValidation.IsValid(500);

            //    if (result)
            //    {
            //        Account account = new Account();
            //        account.Create(customer);
            //        account.Save();
            //    }
            //} 
            #endregion

            AccountContext accountContext = new AccountContext("11111");
            accountContext.CreateAccount(500);

            Console.ReadKey();
        }
    }
}