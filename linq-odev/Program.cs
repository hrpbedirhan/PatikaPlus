namespace linq_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generate random list
            Random random = new Random();
            List<int> numbers = Enumerable.Range(1, 10)
                .Select(x => random.Next(-20, 40))
                .ToList();

            //even numbers
            Console.WriteLine("Çift Sayılar:");
            var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            evenNumbers.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------------");

            //odd numbers
            Console.WriteLine("Tek Sayılar:");
            var oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
            oddNumbers.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------------");

            //negative numbers
            Console.WriteLine("Negatif Sayılar:");
            var negativeNumbers = numbers.Where(x => x < 0).ToList();
            negativeNumbers.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------------");

            //positive numbers
            Console.WriteLine("Poizitif Sayılar:");
            var positiveNumbers = numbers.Where(x => x > 0).ToList();
            positiveNumbers.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------------");

            //condition
            Console.WriteLine("15'ten büyük ve 22'den küçük sayılar:");
            var conditionNumbers = numbers.Where(x => x > 15 && x < 22).ToList();
            conditionNumbers.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------------");

            //the square of all numbers
            Console.WriteLine("Listedeki her bir sayının karesi:");
            var squareNumbers = numbers.Select(x => x * x).ToList();
            squareNumbers.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------------------");

        }
    }
}
