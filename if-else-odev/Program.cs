Console.Write("Lütfen Bir Sayı Giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 10)
    Console.WriteLine("Girilen Sayı 10'dan büyüktür.");
else
    Console.WriteLine("Girilen Sayı 10'dan küçüktür.");

if (number % 2 == 0)
    Console.WriteLine("Girilen Sayı Çifttir.");
else
    Console.WriteLine("Girilen Sayı tektir.");

Console.ReadKey();