using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[5] {"Engin","Murat","Kerem","Halil","" };


            List<string> isimler2 = new List<string> {"Engin", "Murat", "Kerem", "Halil" };
            isimler2.Add("ilker");

            foreach (var yaz in isimler2)
            {
                Console.WriteLine(yaz);
            }
        }
    }
}
