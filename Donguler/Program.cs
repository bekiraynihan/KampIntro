using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = {"java","programlamaya giriş","yazılımcı geliştirme" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                
            }
            Console.ReadLine();

            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
