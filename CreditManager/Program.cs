using System;
using System.Collections.Generic;

namespace CreditManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager mortgage = new MortgageCredit();
            ICreditManager finance = new FinanceCredit();
            ICreditManager loan = new LoanCredit();
            ICreditManager officer = new OfficerCreditService();



            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService emailLoggerService = new EmailLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            


            //mortgage.Calculate();
            //loan.Calculate();
            
            ApplyManager applyManager = new ApplyManager();
            List<ILoggerService> loggerServices = new List<ILoggerService>() { dataBaseLoggerService, smsLoggerService, emailLoggerService, fileLoggerService };
            List<ICreditManager> creditManagers = new List<ICreditManager>() { loan, mortgage, officer, finance };




            //applyManager.ApplyCredit(creditManagers, loggerServices);
            applyManager.ForeCalcMoreCredit(loggerServices, creditManagers);
        }
    }
}
