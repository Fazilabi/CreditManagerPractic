using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManager
{
    class ApplyManager
    {
        public void ApplyCredit(ICreditManager creditManagers, List<ILoggerService> loggerServices)
        {

            creditManagers.Calculate();
            
            Console.WriteLine("------------------------");
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }
        }
        

        public void ForeCalcMoreCredit(List<ILoggerService> loggerServices, List<ICreditManager> creditManagers)
        {
            foreach (var credit in creditManagers)
            {
                credit.Calculate();
            }
            Console.WriteLine("------------------------");
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }
        }
    }
}
