namespace hafta4_kapanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool devamEt = true;
            while (devamEt)
            {
                Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basın:");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Telefon telefon = new Telefon();

                    Console.Write("Seri Numarası: ");
                    telefon.SeriNumarasi = Console.ReadLine();

                    Console.Write("Ad: ");
                    telefon.Ad = Console.ReadLine();

                    Console.Write("Açıklama: ");
                    telefon.Aciklama = Console.ReadLine();

                    Console.Write("İşletim Sistemi: ");
                    telefon.IsletimSistemi = Console.ReadLine();

                    Console.Write("TR Lisanslı mı? (Evet/Hayır): ");
                    string trLisansli = Console.ReadLine();
                    telefon.TrLisansli = trLisansli.ToLower() == "evet";

                    Console.WriteLine("\nÜrün başarıyla üretildi!\n");
                    telefon.BilgileriYazdir();
                    telefon.UrunAdiGetir();
                }
                else if (secim == "2")
                {
                    Bilgisayar bilgisayar = new Bilgisayar();

                    Console.Write("Seri Numarası: ");
                    bilgisayar.SeriNumarasi = Console.ReadLine();

                    Console.Write("Ad: ");
                    bilgisayar.Ad = Console.ReadLine();

                    Console.Write("Açıklama: ");
                    bilgisayar.Aciklama = Console.ReadLine();

                    Console.Write("İşletim Sistemi: ");
                    bilgisayar.IsletimSistemi = Console.ReadLine();

                    Console.Write("USB Giriş Sayısı (2 veya 4): ");
                    int usbGiris;
                    if (int.TryParse(Console.ReadLine(), out usbGiris))
                        bilgisayar.UsbGirisSayisi = usbGiris;

                    Console.Write("Bluetooth var mı? (Evet/Hayır): ");
                    string bluetooth = Console.ReadLine();
                    bilgisayar.Bluetooth = bluetooth.ToLower() == "evet";

                    Console.WriteLine("\nÜrün başarıyla üretildi!\n");
                    bilgisayar.BilgileriYazdir();
                    bilgisayar.UrunAdiGetir();
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                    continue;
                }

                Console.WriteLine("\nBaşka bir ürün üretmek ister misiniz? (Evet/Hayır)");
                string devam = Console.ReadLine();
                devamEt = devam.ToLower() == "evet";
            }

            Console.WriteLine("İyi günler!");
        }
    }
}
