using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999


            //int,decimal,float,double,bool = değer tipi (sayısal görüntüde olanlar)
            //array, class, interface = referans tip
            //bellekte stack ve heap var
            //değer tipler stackte tutulur (sayi1 = 10 gibi)
            //mesela liste oluşturduğunda sayilar1 kismi stackte [10,20,30] kısmı heapte tutulur
        }
    }
}
