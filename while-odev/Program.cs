int ten = 0;
while (ten < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    ten++;
}

Console.WriteLine();
Console.WriteLine("------------------------");

int twenty = 1;
while (twenty <= 20)
{
    Console.Write($"{twenty} ");
    twenty++;
}

Console.WriteLine();
Console.WriteLine("------------------------");

int evenNumber = 1;
while (evenNumber <= 20)
{
    if (evenNumber % 2 == 0)
    {
        Console.Write($"{evenNumber} ");
    }
    evenNumber++;
}

Console.WriteLine();
Console.WriteLine("------------------------");

int sum = 0;
int i = 50;
while (i <= 150)
{
    sum += i;
    i++;
}
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {sum}");

Console.WriteLine();
Console.WriteLine("------------------------");

int oddSum = 0;
int evenSum = 0;
int j = 1;

while (j <= 120)
{
    if (j % 2 == 0)
    {
        evenSum += j;
    }
    else
    {
        oddSum += j;
    }
    j++;
}

Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {evenSum}");
Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {oddSum}");

Console.ReadKey();