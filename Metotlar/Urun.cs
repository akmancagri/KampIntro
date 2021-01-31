using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //property
        public int Id { get; set; } //datada ayirt etmek icin eşşiz bir değer atadık
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
//classlar nesneyi tanimlayan birden fazla bilgiyi ve özelligi barindirirlar