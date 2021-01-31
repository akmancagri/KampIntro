using System;
using System.Collections.Generic;
using System.Text;
//manager, dataAccess , service , controller tarzi anahtar kelimeler
// bir operasyonun tutuldugunu ifade eder
namespace Metotlar
{
    class SepetManager
    {
        //naming convention E harfi buyuk olursa daha iyi
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi: "+ urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi: " + urunAdi);
        }
    }
}
