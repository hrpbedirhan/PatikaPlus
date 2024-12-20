using Dependency_Injection.Interfaces;

namespace Dependency_Injection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeacher teacher = new Teacher("Bedirhan", "Harputluoğlu");

            ClassRoom classRoom = new ClassRoom(teacher);

            Console.WriteLine(classRoom.GetTeacherInfo());
        }
    }
}
