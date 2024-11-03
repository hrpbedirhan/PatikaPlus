using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta4_kapanis
{
    public abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; private set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;  // üretim tarihi nesne oluşturulurken otomatik atanır
        }

        // ortak bilgileri yazdıran metot
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }

        // soyut metot
        public abstract void UrunAdiGetir();
    }

    public class Telefon : BaseMakine
    {
        public bool TrLisansli { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanslı: {(TrLisansli ? "Evet" : "Hayır")}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }

    public class Bilgisayar : BaseMakine
    {
        private int usbGirisSayisi;
        public int UsbGirisSayisi
        {
            get { return usbGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                    usbGirisSayisi = value;
                else
                {
                    Console.WriteLine("USB giriş sayısı yalnızca 2 veya 4 olabilir. Varsayılan olarak -1 atanmıştır.");
                    usbGirisSayisi = -1;
                }
            }
        }
        public bool Bluetooth { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {usbGirisSayisi}");
            Console.WriteLine($"Bluetooth: {(Bluetooth ? "Var" : "Yok")}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }
    }
}
