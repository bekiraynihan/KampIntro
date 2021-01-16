using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            String adi = "bekir";
            int yas = 26;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım";
            kurs1.Egitmen = "Bekir";
            kurs1.IzlenmeOrani = 68;

            //kurs1("aa","bb",12 );

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "abccc";
            kurs2.Egitmen = "ali";
            kurs2.IzlenmeOrani = 612;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "dd";
            kurs3.Egitmen = "veli";
            kurs3.IzlenmeOrani = 438;

            Kurs[] kurslar = { kurs1, kurs2, kurs3 };
            foreach (var kurss in kurslar)
            {
                Console.WriteLine(kurss.KursAdi);
            }
        }
    }
    class Kurs
    {
        public String KursAdi { get; set; }
        public String Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
