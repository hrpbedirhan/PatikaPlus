for (int i = 0; i < 10; i++)
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");

Console.WriteLine("--------------------");

for (int i = 1; i <= 20; i++)
    Console.Write($"{i} ");

Console.WriteLine();
Console.WriteLine("--------------------");

for (int i = 1; i < 20; i++)
    if (i % 2 == 0)
        Console.Write($"{i} ");

Console.WriteLine();
Console.WriteLine("--------------------");

int sum = 0;
for (int i = 50; i <= 150; i++)
    sum += i;
Console.WriteLine(sum);


Console.WriteLine();
Console.WriteLine("--------------------");

int oddSum = 0;
int evenSum = 0;
for (int i = 1; i <= 120; i++)
    if (i % 2 == 0) {
        evenSum += i;
    } else 
        oddSum += i;

Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı {evenSum}");
Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı {oddSum}");

Console.ReadKey();