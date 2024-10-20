
// while ile yapılan yazdırma işlemi 
int counter = 1;
Console.Write("Kaç kere yazsın? Bir sayı girin: ");
int limit = int.Parse(Console.ReadLine());
while (counter <= limit)
{
    Console.WriteLine($"{counter}. Ben bir Patika'lıyım");
    counter++;
}


Console.WriteLine();
Console.WriteLine("------------------------");

// do while ile yapılan yazdırma işlemi
int counterDo = 1;
Console.Write("Kaç kere yazsın? Bir sayı girin: ");
int limitDo = int.Parse(Console.ReadLine());
do
{
    Console.WriteLine($"{counterDo}. Ben bir Patika'lıyım");
    counterDo++;
} while (counterDo <= limitDo);

Console.ReadKey();
