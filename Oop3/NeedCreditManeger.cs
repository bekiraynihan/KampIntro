using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class NeedCreditManeger : ICreditManeger
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı.");
        }

        public void OneDoing()
        {
            Console.WriteLine("İhtiyaç Kredisi Birşeyler yapıld");
        }
    }
}
