using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManager
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Database logged");
        }
    }
}
