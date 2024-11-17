using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaflix_odev
{
    public class ComedySeries
    {
        public ComedySeries() { }
        public ComedySeries(string name, string genre, string director)
        {
            Name = name;
            Genre = genre;
            Director = director;
        }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public void Display()
        {
            Console.WriteLine($"Dizi Adı: {Name}, Türü: {Genre}, Yönetmen: {Director}");
        }
    }
}
