namespace imdb_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ImdbFilmListesi> list = new List<ImdbFilmListesi>();
            string devam;

            do
            {
                // film bilgilerini al
                Console.Write("Film adı giriniz: ");
                string isim = Console.ReadLine();


                Console.Write("IMDb puanını giriniz: ");
                double puan;
                while (!double.TryParse(Console.ReadLine(), out puan))
                {
                    Console.WriteLine("Geçerli bir sayı giriniz.");
                }

                // yeni film nesnesi oluşturup listeye ekleme
                ImdbFilmListesi yeniFilm = new ImdbFilmListesi { Isim = isim, ImdbPuani = puan };
                list.Add(yeniFilm);

                // yeni film eklemek isteyip istemediğini sor
                Console.Write("Yeni bir film eklemek istiyor musunuz? (evet/hayır): ");
                devam = Console.ReadLine().ToLower();

            } while (devam == "evet");

            // bütün filmleri listeliyoruz
            Console.WriteLine("\nTüm Filmler:");
            foreach (var film in list)
            {
                Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
            }

            // IMDb puanı 4 ile 9 arasında olan filmleri listeleme
            Console.WriteLine("\nIMDb puanı 4 ile 9 arasında olan Filmler:");
            var ortaPuanFilmler = list.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9).ToList();
            foreach (var film in ortaPuanFilmler)
            {
                Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
            }

            // ismi 'A' ile başlayan filmler
            Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
            var aIleBaslayanFilmler = list.Where(f => f.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var film in aIleBaslayanFilmler)
            {
                Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
            }

            Console.WriteLine("\nProgram sona erdi. İyi günler!");
        }
    }
}
