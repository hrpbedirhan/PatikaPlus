namespace ctor_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baby baby = new Baby();
            baby.Name = "Esin";
            baby.Surname = "Yalın";
            baby.GetBabyInfo();

            Console.WriteLine("------------------------");

            Baby baby2 = new Baby("Şeyma", "Güler");
            baby2.GetBabyInfo();

            Console.ReadKey();
        }
    }
}
