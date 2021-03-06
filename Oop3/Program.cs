﻿using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManeger needCreditManeger = new NeedCreditManeger();
            //needCreditManeger.Calculate();
            ICreditManeger vehicleCreditManeger= new VehicleCreditManeger();
            //vehicleCreditManeger.Calculate();
            ICreditManeger housingCreditManeger = new HousingCreditManeger();
            //housingCreditManeger.Calculate();
            
            ILoggerService FloggerService = new DateBaseLoggerSevice();
            ILoggerService DloggerService = new FileLoggerSevice();

            List<ILoggerService> Liste = new List<ILoggerService>();
            Liste.Add(FloggerService);
            Liste.Add(DloggerService);

            RecourseManeger recourseManeger = new RecourseManeger();
           recourseManeger.BasvuruYap(needCreditManeger,Liste);
            
            
            List<ICreditManeger> credits = new List<ICreditManeger>();
            credits.Add(housingCreditManeger);
            credits.Add(needCreditManeger);
            credits.Add(vehicleCreditManeger);
            //recourseManeger.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
