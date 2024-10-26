namespace class_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //teacher 1
            Person t1 = new Person();
            t1.Name = "Ahmet";
            t1.Surname = "Çelik";
            t1.BornDate = 1987;
            //teacher 2
            Person t2 = new Person();
            t2.Name = "Yunus";
            t2.Surname = "Yiğit";
            t2.BornDate = 1993;
            //student 1
            Person s1 = new Person();
            s1.Name = "Ecrin";
            s1.Surname = "Demirci";
            s1.BornDate = 2010;
            //student 2
            Person s2 = new Person();
            s2.Name = "Arda";
            s2.Surname = "Güler";
            s2.BornDate = 2011;

            //write console
            t1.PersonInfo();
            t2.PersonInfo();
            s1.PersonInfo();
            s2.PersonInfo();
        }
    }
}
