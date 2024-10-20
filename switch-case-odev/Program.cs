namespace switch_case_odev
{
    internal class Program
    {
        // değişkenleri tutmak için enum kullanmak istedim aslında gerek yoktu ama kullanmak istedim
        // bu arada enumları metodun dışında tanımlamamız gerekiyor..
        enum Fruits
        {
            Elma = 2,
            Armut = 3,
            Cilek = 2,
            Muz = 3,
            Diger = 4
        }

        static void Main(string[] args)
        {
            // önce meyve fiyatlarını yazdırıyorum
            Console.WriteLine($"Elma = {(int)Fruits.Elma} TL");
            Console.WriteLine($"Armut = {(int)Fruits.Armut} TL");
            Console.WriteLine($"Çilek = {(int)Fruits.Cilek} TL");
            Console.WriteLine($"Muz = {(int)Fruits.Muz} TL");
            Console.WriteLine($"Diğer bütün meyveler = {(int)Fruits.Diger} TL");

            Console.Write("Hangi Meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
            // kullanıcıdan istediği meyveyi yazmasını istiyorum
            string fruit = Console.ReadLine();

            // kullanıcının yazdığı meyvenin harflerini küçültüyorum ki switch case yapısı düzgün çalışsın
            switch (fruit.ToLower())
            {
                case "elma":
                    Console.WriteLine($"Seçtiğiniz meyve: Elma. Fiyatı: {(int)Fruits.Elma} TL");
                    break;
                case "armut":
                    Console.WriteLine($"Seçtiğiniz meyve: Armut. Fiyatı: {(int)Fruits.Armut} TL");
                    break;
                case "çilek":
                    Console.WriteLine($"Seçtiğiniz meyve: Çilek. Fiyatı: {(int)Fruits.Cilek} TL");
                    break;
                case "muz":
                    Console.WriteLine($"Seçtiğiniz meyve: Muz. Fiyatı: {(int)Fruits.Muz} TL");
                    break;
                case "diğer":
                    Console.WriteLine($"Seçtiğiniz meyve: Diğer meyveler. Fiyatı: {(int)Fruits.Diger} TL");
                    break;
                default:
                    Console.WriteLine("Geçersiz bir meyve seçimi yaptınız. Lütfen geçerli bir meyve adı girin.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
