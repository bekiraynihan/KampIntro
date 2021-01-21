﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class RecourseManeger
    {
        public void BasvuruYap(ICreditManeger creditManeger, ILoggerService loggerService) 
        {
            creditManeger.Calculate();
            loggerService.Log();
        
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManeger> credits)
        {
            foreach (ICreditManeger krediler in credits)
            {
                krediler.Calculate();
            }
        }
    }
}
