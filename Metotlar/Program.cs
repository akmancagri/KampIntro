using System;
// tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır
// mesela "sepete ekle" butonu metotlara örnektir
//dont repeat yourself and clean code

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //class tanimlandi
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("-------------Metotlar-------------");
            //instance - ornek
            //encapsulation 

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("------------------");
            sepetManager.Ekle2("Armut", "Yeşil", 12);
            sepetManager.Ekle2("Keşkek", "Mor", 12);

            // bu sekilde uygun değil cunku degisiklik oldugu zaman degisim zor olur
            // bu yuzden classları kullanmaliyiz


        }
    }
}


