using System.Collections.Generic;

namespace patikaflix_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create our series database
            List<Series> seriesList = new List<Series>()
            {
                new Series("Avrupa Yakası", 2004, "Komedi", 2004, "Yüksel Aksu", "Kanal D"),
                new Series("Yalan Dünya", 2012, "Komedi", 2012, "Gülseren Buda Başkaya", "Fox TV"),
                new Series("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren Buda Başkaya", "TV8"),
                new Series("Dadı", 2006, "Komedi", 2006, "Yusuf Pirhasan", "Kanal D"),
                new Series("Belalı Baldız", 2007, "Komedi", 2007, "Yüksel Aksu", "Kanal D"),
                new Series("Arka Sokaklar", 2004, "Polisiye, Dram", 2004, "Orhan Oğuz", "Kanal D"),
                new Series("Aşk-ı Memnu", 2008, "Dram, Romantik", 2008, "Hilal Saral", "Kanal D"),
                new Series("Muhteşem Yüzyıl", 2011, "Tarihi, Dram", 2011, "Mercan Çilingiroğlu", "Star TV"),
                new Series("Yaprak Dökümü", 2006, "Dram", 2006, "Yüksel Aksu", "Kanal D")
            };

            string userChoice;

            //user adds a new series
            do
            {
                Console.WriteLine("Yeni bir dizi eklemek istiyor musunuz? (E/H): ");
                userChoice = Console.ReadLine().ToUpper();

                if (userChoice == "E")
                {
                    Console.Write("Dizi Adı: ");
                    string name = Console.ReadLine();

                    Console.Write("Yapım Yılı: ");
                    int constructionYear = int.Parse(Console.ReadLine());

                    Console.Write("Türü: ");
                    string genre = Console.ReadLine();

                    Console.Write("Çıkış Yılı: ");
                    int publicationYear = int.Parse(Console.ReadLine());

                    Console.Write("Yönetmen: ");
                    string director = Console.ReadLine();

                    Console.Write("Kanal: ");
                    string platform = Console.ReadLine();

                    seriesList.Add(new Series(name, constructionYear, genre, publicationYear, director, platform));
                }
            } while (userChoice != "H");

            //creating a new list from comedy series
            List <ComedySeries> comedySeriesList = seriesList
                .Where(s => s.Genre.ToLower().Contains("komedi"))
                .Select(s => new ComedySeries(s.Name, s.Genre, s.Director))
                .OrderBy(s => s.Name)
                .ThenBy(s => s.Director)
                .ToList();

            //print the comedy series
            Console.WriteLine("\n###### Komedi Dizileri Listesi #######");
            Console.WriteLine("{0,-20} {1,-20} {2,-30}", "Dizinin Adı", "Türü", "Yönetmenler");
            comedySeriesList.ForEach(cs =>
                Console.WriteLine("{0,-20} {1,-20} {2,-30}", cs.Name, cs.Genre, cs.Director));
        }
    }
}
