namespace inheritance_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor tanımı yapmadan da süslü parantez ile nesnenin içine girip bu şekilde tanımlama yapabiliyoruz
            Ogrenci ogrenci = new Ogrenci { Ad = "Ecrin", Soyad = "Çakır", OgrenciNumarasi = 12345};
            ogrenci.OgrenciBilgileriYazdir();

            Ogretmen ogretmen = new Ogretmen { Ad = "Bedirhan", Soyad = "Harputluoğlu", Maas = 20000 };
            ogretmen.OgretmenBilgileriYazdir();
        }
    }
}
