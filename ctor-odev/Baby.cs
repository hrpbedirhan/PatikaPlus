using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctor_odev
{
    public class Baby
    {
        //the first constructor is parameterless
        public Baby()
        {
            Console.WriteLine("Ingaaaa");
            BornDate = DateTime.Now;
        }

        //the second constructor is parameter
        public Baby(string name, string surname)
        {
            Console.WriteLine("Ingaaaa");
            Name = name;
            Surname = surname;
            BornDate = DateTime.Now;
        }

        //proporties
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BornDate { get; set; }

        //print baby information
        public void GetBabyInfo()
        {
            Console.WriteLine($"Ad: {Name}, Soyad: {Surname}, Doğum Tarihi: {BornDate}");
        }
    }
}
