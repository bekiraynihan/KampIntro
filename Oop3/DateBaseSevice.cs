using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class DateBaseLoggerSevice : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı.");
        }
    }
}
