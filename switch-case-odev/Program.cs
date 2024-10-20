namespace switch_case_odev
{
    internal class Program
    {
        enum Fruits
                {
                    Elma = 2,
                    Armut = 3,
                    Cilek = 2,
                    Muz = 3,
                    Diger = 4
                }
        static void Main(string[] args)
        {

            Console.WriteLine($"Elma = {(int)Fruits.Elma} TL");
            Console.WriteLine($"Armut = {(int)Fruits.Armut} TL");
            Console.WriteLine($"Çilek= {(int)Fruits.Cilek} TL");
            Console.WriteLine($"Muz = {(int)Fruits.Muz} TL");
            Console.WriteLine($"Diger bütün meyveler = {(int)Fruits.Diger} TL");

            Console.Write("Hangi Meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");
            string fruit = Console.ReadLine();

            switch (fruit.ToLower())
            {
                

            }


            Console.ReadKey();

        }
    }
}
