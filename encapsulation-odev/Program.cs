namespace encapsulation_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Corolla", "Mavi", 4);
            Car car2 = new Car("Honda", "Civic", "Beyaz", 3);
            Car car3 = new Car("BMW", "5.20d", "Siyah", 4);
            Car car4 = new Car("Fiat", "500L", "Kırmızı", 2);

            car1.GetCarInfo();
            Console.WriteLine("--------------------------");
            car2.GetCarInfo();
            Console.WriteLine("--------------------------");
            car3.GetCarInfo();
            Console.WriteLine("--------------------------");
            car4.GetCarInfo();
        }
    }
}
