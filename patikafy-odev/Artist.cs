using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikafy_odev
{
    public class Artist
    {
        public Artist() { }

        public Artist(string fullName, string genre, int debutYear, int albumSales)
        {
            FullName = fullName;
            Genre = genre;
            DebutYear = debutYear;
            AlbumSales = albumSales;
        }
        public string FullName { get; set; }
        public string Genre { get; set; }
        public int DebutYear { get; set; }
        public int AlbumSales { get; set; }

        public override string ToString()
        {
            return $"{FullName} {Genre} {DebutYear} Yaklaşık {AlbumSales/1000000} milyon";
        }

    }
}
