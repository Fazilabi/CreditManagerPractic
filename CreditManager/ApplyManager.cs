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
        

        public void ForeCalcMoreCredit(ILoggerService loggerService, List<ICreditManager> creditManagers)
        {
            foreach (var credit in creditManagers)
            {
                credit.Calculate();
            }
            Console.WriteLine("------------------------");
           
                loggerService.Log();
           
        }
    }
}
