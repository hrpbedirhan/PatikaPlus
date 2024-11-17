using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group_join_odev
{
    public class Students
    {
        public Students(int studentId, string studentName, int classId)
        {
            StudentId = studentId;
            StudentName = studentName;
            ClassId = classId;
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
    }
}
