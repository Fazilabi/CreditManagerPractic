using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManager
{
    class OfficerCreditService : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Officer credit calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
