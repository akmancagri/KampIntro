using System;

namespace odevIcinDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "Sandisk 240 GB SSD Plus";
            urun1.UrunFiyati = 249;
            urun1.UrunSaticisi = "amazon.com.tr";
            urun1.UrunPuani = 3.9;

            Product urun2 = new Product();
            urun2.UrunAdi = "AMD Ryzen 3 3100";
            urun2.UrunFiyati = 983;
            urun2.UrunSaticisi = "Trendyol";
            urun2.UrunPuani = 4.2;

            Product urun3 = new Product();
            urun3.UrunAdi = "Gigabyte B450M Anakart";
            urun3.UrunFiyati = 569;
            urun3.UrunSaticisi = "HepsiBurada";
            urun3.UrunPuani = 4.8;

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün: "+ urun.UrunAdi + "-" + "Fiyat: " + urun.UrunFiyati + "-" + "Satıcı: " + urun.UrunSaticisi + "-" + "Puan: " + urun.UrunPuani);
            }
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi +"-"+urunler[i].UrunFiyati+"-"+urunler[i].UrunSaticisi+"-"+urunler[i].UrunPuani);

            }
            Console.WriteLine("--------------------------------------");

            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunAdi+"-"+urunler[j].UrunFiyati+"-"+urunler[j].UrunSaticisi+"-"+urunler[j].UrunPuani);
                j++;
            }

        }
    }

    class Product
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public string UrunSaticisi { get; set; }
        public double UrunPuani { get; set; }
    }
}
