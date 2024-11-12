namespace patikafy_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create our artist database
            List<Artist> artists = new List<Artist>()
            {
                new Artist("Ajda Pekkan", "Pop", 1968, 20000000),
                new Artist("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10000000),
                new Artist("Funda Arar", "Pop", 1999, 3000000),
                new Artist("Sertab Erener", "Pop", 1994, 5000000),
                new Artist("Sıla", "Pop", 2009, 3000000),
                new Artist("Serdar Ortaç", "Pop", 1994, 10000000),
                new Artist("Tarkan", "Pop", 1992, 40000000),
                new Artist("Hande Yener", "Pop", 1999, 7000000),
                new Artist("Hadise", "Pop", 2005, 5000000),
                new Artist("Gülben Ergen", "Türk Halk Müziği / Pop", 1997, 10000000),
                new Artist("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1968, 2000000),
            };

            //artists names start with 'S'
            var artistStartWithS = artists.Where(a => a.FullName.StartsWith('S')).ToList();
            Console.WriteLine("Adı 'S' ile başlayan sanatçılar:");
            artistStartWithS.ForEach(s =>  Console.WriteLine(s.FullName));

            //artist with album sales of over 10 million
            Console.WriteLine();
            Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
            var albumSales = artists.Where(a => a.AlbumSales > 10000000).ToList();
            albumSales.ForEach(a => Console.WriteLine(a.FullName));

            //pre 2000 pop artists grouped by year and sorted alphabetically within groups
            Console.WriteLine();
            Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
            var debutYear = artists.Where(d => d.DebutYear < 2000 && d.Genre.Contains("Pop"))
                                   .GroupBy(d => d.DebutYear)
                                   .OrderBy(d => d.Key)
                                   .ToList();

            foreach (var group in debutYear)
            {
                Console.WriteLine($"Yıl: {group.Key}");
                foreach (var artist in group)
                {
                    Console.WriteLine(artist.FullName); 
                }
                Console.WriteLine();
            }

            //artists with highest album sales
            var topSellerArtist = artists.OrderByDescending(a => a.AlbumSales).First();
            Console.WriteLine($"En çok albüm satan şarkıcı: {topSellerArtist.FullName}");

            //newest and oldest artists
            Console.WriteLine();
            var newArtist = artists.OrderByDescending(n => n.DebutYear).First();
            var oldArtist = artists.OrderBy(o => o.DebutYear).First();
            Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newArtist.FullName}");
            Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldArtist.FullName}");
        }
    }
}
