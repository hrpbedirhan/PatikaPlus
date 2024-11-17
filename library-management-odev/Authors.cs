using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_odev
{
    public class Authors
    {
        public Authors(int id, string name)
        {
            AuthorId = id;
            Name = name;
        }
        public int AuthorId { get; set; }
        public string Name { get; set; }
    }
}
