namespace polymorphism_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //square
            Kare kare = new Kare { Genislik = 10, Yukseklik = 10};
            Console.WriteLine($"Kare alanı: {kare.AlanHesapla()}");

            //rectangle
            Dikdortgen dikdortgen = new Dikdortgen { Genislik = 20, Yukseklik = 12};
            Console.WriteLine($"Dikdörgen alanı: {dikdortgen.AlanHesapla()}");

            //triangle
            DikUcgen dikUcgen = new DikUcgen { Genislik = 10, Yukseklik = 15 };
            Console.WriteLine($"Dik Üçgen alanı: {dikUcgen.AlanHesapla()}");
        }
    }
}
