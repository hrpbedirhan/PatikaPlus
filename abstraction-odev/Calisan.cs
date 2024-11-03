using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_odev
{
    public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        public abstract void Gorev();

    }

    public class YazilimGelistirici : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} Yazılım geliştirici olarak çalışıyorum.");
        }
    }

    public class ProjeYöneticisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} Proje yöneticisi olarak çalışıyorum.");
        }
    }
        public class SatisTemsilcisi : Calisan
        {
            public override void Gorev()
            {
                Console.WriteLine($"{Ad} {Soyad} Satış temsilcisi olarak çalışıyorum.");
            }
        }
}
