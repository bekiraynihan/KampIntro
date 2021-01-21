using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class HousingCreditManeger : ICreditManeger
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı.");
        }

        public void OneDoing()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı.");
        }
    }
}
