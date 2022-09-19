using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Facade
{
    internal class Customer
    {
        public Customer(string tckn)
        {
            TCKN = tckn;
        }

        public string TCKN { get; set; }
        public string Name { get; set; }
    }
}
