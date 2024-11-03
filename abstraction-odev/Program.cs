namespace abstraction_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjeYöneticisi projeYöneticisi = new ProjeYöneticisi { Ad = "Hasan", Soyad = "Çıldırmış", Departman = "Proje Yönetimi"};
            projeYöneticisi.Gorev();

            YazilimGelistirici yazilimGelistirici = new YazilimGelistirici { Ad="Burak", Soyad="Öz", Departman="Yazılım"};
            yazilimGelistirici.Gorev();

            SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi { Ad="Yaren", Soyad="Kara", Departman="Satış" };
            satisTemsilcisi.Gorev();

        }
    }
}
