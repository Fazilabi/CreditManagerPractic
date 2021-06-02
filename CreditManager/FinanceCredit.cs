using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManager
{
    class FinanceCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Finance credit calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }

       
    }
}
