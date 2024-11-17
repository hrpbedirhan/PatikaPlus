using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace patikaflix_odev
{
    public class Series
    {
        public Series() { }
        public Series(string name, int constructionYear, string genre, int publicationYear, string director, string platform)
        {
            Name = name;
            ConstructionYear = constructionYear;
            Genre = genre;
            PublicationYear = publicationYear;
            Director = director;
            Platform = platform;
        }
        public string Name { get; set; }
        public int ConstructionYear { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public string Director { get; set; }
        public string Platform { get; set; }

    }
}
