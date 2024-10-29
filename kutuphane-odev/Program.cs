namespace kutuphane_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            //new anahtar kelimesi claas üzerinden yeni bir nesne oluşturmak için kullanılır
            book1.Name = "Bir Kitap";
            book1.WriterName = "Ahmet";
            book1.WriterSurname = "Yılmaz";
            book1.PageNumber = 320;
            book1.PublishHouse = "Alfa Yayınları";

            Book book2 = new Book("Başka Bir Kitap", "Ayşe", "Karan", 215, "Beta Yayıncılık");
            Book book3 = new Book("Daha Başka Kitap", "Mehmet", "Demir", 450, "Gamma Yayınları");
            Book book4 = new Book("Son Kitap", "Elif", "Şahin", 275, "Delta Yayıncılık");
            Book book5 = new Book("Örnek Kitap", "Selin", "Yurt", 198, "Epsilon Yayınları");

            book1.GetBookInfo();
            Console.WriteLine("------------------------");
            book2.GetBookInfo();
            Console.WriteLine("------------------------");
            book3.GetBookInfo();
            Console.WriteLine("------------------------");
            book4.GetBookInfo();
            Console.WriteLine("------------------------");
            book5.GetBookInfo();
        }
    }
}
