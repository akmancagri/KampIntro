using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Abdulmuttalip";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Çağrı Akman";
            kurs1.IzlemeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Mahmut Tuncer";
            kurs2.IzlemeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Hayrettin Yücedağ";
            kurs3.IzlemeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen)

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    //kendi classımızı olusturduk
    class Kurs
    {
        public string KursAdi { get; set; } //prop yazıp tabtab yaptik
        public string Egitmen { get; set; }
        public int IzlemeOrani { get; set; }  //prop propertiesden gelir
        //birkaç şeyi tutan bir tip tanımladık

    }
}
