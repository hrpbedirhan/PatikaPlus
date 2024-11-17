namespace library_management_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //authors table
            List<Authors> authors = new List<Authors>()
            {
                new Authors(1, "Orhan Pamuk"),
                new Authors(2, "Elif Şafak"),
                new Authors(3, "Ahmet Ümit")
            };

            //books table
            List<Books> books = new List<Books>()
            {
                new Books(1, "Kar", 1),
                new Books(2, "İstanbul", 1),
                new Books(3, "10 Minutes 38 Seconds in This Strange World", 2),
                new Books(4, "Beyoğlu Rapsodisi", 3)
            };

            //linq query
            var query = from book in books
                        join author in authors
                        on book.AuthorId equals author.AuthorId
                        select new { BookTitle = book.Title, AuthorName = author.Name };

            //print the result
            Console.WriteLine("{0,-50} {1,-20}", "Kitap", "Yazar");
            foreach (var item in query)
            {
                Console.WriteLine("{0,-50} {1,-20}", item.BookTitle, item.AuthorName);
            }
        }
    }
}
