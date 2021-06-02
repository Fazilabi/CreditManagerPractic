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
            List<ILoggerService> loggerServices = new List<ILoggerService>() { dataBaseLoggerService,smsLoggerService, emailLoggerService, fileLoggerService};
            //List<ICreditManager> creditManagers = new List<ICreditManager>() { loan, mortgage, officer };

            ApplyManager applyManager = new ApplyManager();



            applyManager.ApplyCredit(loan, loggerServices);
            //applyManager.ForeCalcMoreCredit(loggerServices, creditManagers);
        }
    }
}
