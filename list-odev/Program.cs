namespace list_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Davetliler **");

            //created list
            List<string> guests = new List<string>()
            {
                "Bülent Ersoy",
                "Ajda Pekkan",
                "Ebru Gündeş",
                "Hadise",
                "Hande Yener",
                "Tarkan",
                "Funda Arar",
                "Demet Akalın"
            };

            //print the list elements
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {guests[i]}");
            }
        }
    }
}
