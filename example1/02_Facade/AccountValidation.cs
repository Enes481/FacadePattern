using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Facade
{
    internal class AccountValidation
    {
        public bool IsValid(decimal money)
        {
            return money > 0;
        }
    }
}
