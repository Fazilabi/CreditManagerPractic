using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManager
{
    class LoanCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Loan credit calculated");
        }
        public void DoSomething()
        {
            throw new NotImplementedException();
        }

        
    }
}
