﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CreditManager
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("File logged");
        }
    }
}
