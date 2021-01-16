using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2;
            sayi1=double.Parse(Console.ReadLine());
            sayi2=double.Parse(Console.ReadLine());
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(sayi1, sayi2);
        }
    }
}
