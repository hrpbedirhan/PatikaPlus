namespace group_join_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //students table
            List<Students> students = new List<Students>()
            {
                new Students(1, "Ali", 1),
                new Students(2, "Ayşe", 2),
                new Students(3, "Mehmet", 1),
                new Students(4, "Fatma", 3),
                new Students(5, "Ahmet", 2)
            };

            //classes table
            List<Classes> classes = new List<Classes>()
            {
                new Classes(1, "Matematik"),
                new Classes(2, "Türkçe"),
                new Classes(3, "Kimya")
            };

            //linq group join query
            var groupJoinQuery = from cls in classes
                                 join std in students
                                 on cls.ClassId equals std.ClassId into studentGroup
                                 select new
                                 {
                                     ClassName = cls.ClassName,
                                     Students = studentGroup
                                 };

            //print the result
            Console.WriteLine("Sınıflar ve Öğrencileri:");
            Console.WriteLine("-------------------------");
            foreach (var item in groupJoinQuery)
            {
                Console.WriteLine($"{item.ClassName} Sınıfı");
                if (item.Students.Any())
                {
                    foreach (var student in item.Students)
                    {
                        Console.WriteLine($" - {student.StudentName}");
                    }
                }
                else
                {
                    Console.WriteLine("- Bu sınıfta öğrenci yok");
                }
            }
        }
    }
}
