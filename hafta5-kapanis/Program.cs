namespace hafta5_kapanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            while (true)
            {
                Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
                string answer = Console.ReadLine().Trim().ToLower();

                if (answer!="e" && answer!="h")
                {
                    Console.WriteLine("Geçersiz giriş lütfen 'e' veya 'h' giriniz.");
                    continue;
                }

                if (answer=="h")
                {
                    break;
                }

                Car car = new Car();

                Console.Write("Seri numarası: ");
                car.SerialNumber = Console.ReadLine();

                Console.Write("Marka: ");
                car.Brand = Console.ReadLine();

                Console.Write("Model: ");
                car.Model = Console.ReadLine();

                Console.Write("Renk: ");
                car.Color = Console.ReadLine();

            NumberOfDoor:
                try
                {
                    Console.Write("Kapı Sayısı: ");
                    car.DoorCount = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer giriniz.");
                    goto NumberOfDoor;
                }

                cars.Add(car);

                Console.Write("Başka bir araba üretmek istiyor musunuz? (e/h): ");
                string continueAnswer = Console.ReadLine().Trim().ToLower();

                if (continueAnswer == "h")
                {
                    break;
                }
            }

            Console.WriteLine("\nÜretilen Arabalar:");
            foreach (Car car in cars)
            {
                Console.WriteLine($"Seri Numarası: {car.SerialNumber}, Marka: {car.Brand}");
            }
        }
    }
}
