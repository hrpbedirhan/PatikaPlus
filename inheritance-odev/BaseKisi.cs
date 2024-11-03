using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_odev
{
    //miras alınacak kişi sınıfı
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void AdSoyadYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    //miras alan öğrenci sınıfı
    public class Ogrenci : BaseKisi
    {
        public int OgrenciNumarasi { get; set; }

        public void OgrenciBilgileriYazdir()
        {
            Console.WriteLine($"Öğrenci No: {OgrenciNumarasi}");
            AdSoyadYazdir();
        }
    }

    //miras alan öğretmen sınıfı
    public class Ogretmen : BaseKisi 
    {
        public decimal Maas { get; set; }

        public void OgretmenBilgileriYazdir()
        {
            Console.WriteLine($"Maaş: {Maas}");
            AdSoyadYazdir();
        }
    }
}
