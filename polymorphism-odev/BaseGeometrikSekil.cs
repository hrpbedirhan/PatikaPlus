using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_odev
{
    //base class
    public class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    //square class
    public class Kare : BaseGeometrikSekil
    {
        public override double AlanHesapla()
        {
            return base.AlanHesapla();
        }
    }

    //rectangle class
    public class Dikdortgen : BaseGeometrikSekil
    {
        public override double AlanHesapla()
        {
            return base.AlanHesapla();
        }
    }

    //triangle class
    public class DikUcgen : BaseGeometrikSekil
    {
        public override double AlanHesapla()
        {
            return (Genislik*Yukseklik)/2;
        }
    }
}
