namespace kahve_list_dev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffee = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Kahve {i}");
            }
        }
    }
}
