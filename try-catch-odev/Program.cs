namespace try_catch_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Lütfen bir sayı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Girdiğiniz sayının karesi: {Math.Pow(number, 2)}");
            }
            catch ( FormatException ) 
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        }
    }
}
