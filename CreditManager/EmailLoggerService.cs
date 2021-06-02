using System;

namespace CreditManager
{
    class EmailLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Email logged");
        }
    }
}
