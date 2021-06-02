using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManager
{
    class MortgageCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage credit calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }

       
    }
}
