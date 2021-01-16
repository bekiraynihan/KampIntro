using System;
using System.Collections.Generic;
using System.Text;

namespace MetotlarIntro
{
    class SepetManager
    {
        public void ekle(Urun urun) {
            Console.WriteLine("Sepete ürün eklendi: "+urun.Adi);
        }
        public void ekle2(string urunadi,string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete ürün eklendi: " + urunadi);
        }
    }
}
