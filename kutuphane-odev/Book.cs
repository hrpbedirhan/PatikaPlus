using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_odev
{
    internal class Book
        //class bir yapıyı tanımlamak için kullanılan şablondur
    {

        public Book()
        {
            RegistrationDate = DateTime.Now;
        }

        public Book(string name, string writerName, string writerSurname, int pageNumber, string publishHouse)
        {
            Name = name;
            WriterName = writerName;
            WriterSurname = writerSurname;
            PageNumber = pageNumber;
            PublishHouse = publishHouse;
            RegistrationDate = DateTime.Now;
        }
        //constructor sınıf örneği oluşturulurken çalışan özel bir metot


        //property definition
        public string Name { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public int PageNumber { get; set; }
        public string PublishHouse { get; set; }
        private DateTime RegistrationDate { get; set; }
        //property class alanlarını kapsülleyerek onlara kontrollü şekilde erişim için kullanılır


        //kitap bilgilerini yazdıran metot void kelimesi metot hiçbir şey döndürmüyorsa eklenir
        public void GetBookInfo()
        {
            Console.WriteLine($"Ad: {Name}, Yazar adı: {WriterName}, Yazar soyadı: {WriterSurname}, Sayfa Sayısı: {PageNumber}, Yayınevi {PublishHouse}, Kayıt Tarihi: {RegistrationDate}");
        }
    }
}
