using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class FileLoggerSevice : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya Loglandı.");
        }
    }
}
