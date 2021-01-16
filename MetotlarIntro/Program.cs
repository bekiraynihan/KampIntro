using System;

namespace MetotlarIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach ( Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("****************************");
            }
            Console.WriteLine("**************METODLAR**************");
            //instance örnek
            //encapsulation
            SepetManager sepetManeger = new SepetManager();
            sepetManeger.ekle(urun1);

            sepetManeger.ekle2("armut", "yesşil armut", 12);
            sepetManeger.ekle2("elma", "yesşil elma", 11);
        }
    }
}
