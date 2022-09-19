using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Facade
{
    // Facade Nesnesi
    internal class AccountContext
    {
        Customer customer;
        Account account;
        TCKNService tcknService;
        BlackListService blackListService;
        AccountValidation accountValidation;

        public AccountContext(string tckn)
        {
            customer = new Customer(tckn);
            account = new Account();
            tcknService = new TCKNService();
            blackListService = new BlackListService();
            accountValidation = new AccountValidation();
        }

        public void CreateAccount(decimal money)
        {
            customer.Name = tcknService.GetInfoByTCKN(customer.TCKN);
            bool result = blackListService.IsBlock(customer.TCKN);

            if (!result)
            {
                result = accountValidation.IsValid(money);
                if (result)
                {
                    account.Create(customer);
                    account.Save();
                }
            }
        }
    }
}
