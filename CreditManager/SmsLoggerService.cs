using System;

namespace CreditManager
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms logged");
        }
    }
}
