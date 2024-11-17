using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group_join_odev
{
    public class Classes
    {
        public Classes(int classId, string className)
        {
            ClassId = classId;
            ClassName = className;
        }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
