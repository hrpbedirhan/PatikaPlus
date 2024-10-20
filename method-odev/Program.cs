// Geriye Değer Döndürmeyen Bir void metot
using System.Reflection.Metadata;

static void getSong()
{
    Console.WriteLine("Sen gelmez oldun...");
}

getSong();

Console.WriteLine("-----------------------------");

// Geriye Tamsayı Döndüren Bir metot
static int randomNumber()
{
    Random rand = new Random();
    int randomNumber = rand.Next();
    randomNumber = randomNumber % 2;

    return randomNumber;
}

int number =  randomNumber();
Console.WriteLine(number);

Console.WriteLine("-----------------------------");

// Parametre Alan ve Geriye Değer Döndüren Bir Metot
static int multiplication(int x, int y)
{
    return x * y;
}

int result = multiplication(3, 5);
Console.WriteLine(result);

Console.WriteLine("-----------------------------");

// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
static void greeting(string name , string surname)
{
    Console.WriteLine($"Hoş Geldiniz {name} {surname}");
}

greeting("Bedirhan", "Harputluoğlu");

Console.ReadKey();