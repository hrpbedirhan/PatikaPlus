using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_odev
{
    public class Books
    {
        public Books(int bookId, string title, int authorId)
        {
            BookId = bookId;
            Title = title;
            AuthorId = authorId;
        }
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
