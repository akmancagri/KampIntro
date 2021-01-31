using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            // yukardaki gibi yazılım şekli uzundur,zordur dinamik değildir!
            //bu tip veriler dizilerde tutulur - array

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs","Java","Python",
            "C++","C#"};

            for (int i = 0; i<kurslar.Length; i++) //i=i+2 , i+=2 şeklinde de yazilabilir
            { //kurslar.Length eleman sayısı kadar yazdırır "DİNAMİZM!!"
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            // farklı bir döngü yöntemi
            // dizi temelli yapıları tek tek dönmeye yarar, foreach dizilere uygulanır
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer ");
        }
    }
}
