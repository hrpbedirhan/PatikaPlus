namespace kahve_list_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //created list
            List<string> coffee = new List<string>();

            //add coffee
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Kahve {i}: ");
                string item = Console.ReadLine();
                coffee.Add(item);
            }

            //print the coffe elements
            Console.WriteLine("Girilen Kahve İsimleri:");
            foreach (string c in coffee)
                Console.WriteLine(c);
        }
    }
}
