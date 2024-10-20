Console.WriteLine("Merhaba\r\nNasılsın?\r\nİyiyim\r\nSen nasılsın?");

Console.WriteLine("--------------------------------");

string film = "Poor Things";
int no = 3;
Console.WriteLine($"{film} {no}");

Console.WriteLine("--------------------------------");

Random rnd = new Random();
int number = rnd.Next(1, 101);
Console.WriteLine("1-100 aralığında rastgele bir sayı: " + number);

Console.WriteLine("--------------------------------");

int sayi = new Random().Next(100);
Console.WriteLine("Rastgele bir sayı: {0}{2}Üçe bölümden kalan: {1}",
    sayi,
    sayi % 3,
    Environment.NewLine);

Console.WriteLine("--------------------------------");

int age;
Console.Write("Yaşınız: ");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(age >= 18 ? "+" : "-");

Console.WriteLine("--------------------------------");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
}


Console.WriteLine("--------------------------------");

Console.Write("Ad 1: ");
string name1 = Console.ReadLine();
Console.Write("Ad 2: ");
string name2 = Console.ReadLine();
Console.WriteLine($"Değişimden önce : {name1} ve {name2}");
string backup = name1;
name1 = name2;
name2 = backup;
Console.WriteLine($"Değişimden sonra: {name1} ve {name2}");

Console.WriteLine("--------------------------------");

static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
}

BenDegerDondurmem();

Console.WriteLine("--------------------------------");

double Sum(double a, double b) => a + b;
Console.WriteLine("3.2 ve 4.5'ün toplamı: " + Sum(3.2, 4.5));


Console.WriteLine("--------------------------------");

string Answer(bool c)
{
    return c ? "Evet" : "Hayır";
}
Console.WriteLine("Benimle C# yazar mısın : " + Answer(true));
Console.WriteLine("Benimle köfte yer misin: " + Answer(false));

Console.WriteLine("--------------------------------");
int FindMaxAge(int y1, int y2, int y3)
{
    return Math.Max(Math.Max(y1, y2), y3);
}
Console.WriteLine(FindMaxAge(15, 18, 14));

Console.WriteLine("--------------------------------");

int MaxNumber(params int[] dizi)
{
    return dizi.Max();
}
Console.WriteLine(MaxNumber(48, 483, 99, -50, 9999));

Console.WriteLine("--------------------------------");
void Replace(ref string a, ref string b)
{
    string backup = a;
    a = b;
    b = backup;
}

Console.Write("Ad 1: ");
string ad1 = Console.ReadLine();

Console.Write("Ad 2: ");
string ad2 = Console.ReadLine();

Console.WriteLine($"Önce : {ad1} {ad2}");
Replace(ref ad1, ref ad2);
Console.WriteLine($"Sonra: {ad1} {ad2}");

Console.WriteLine("--------------------------------");

bool CiftMi(int sayi)
{
    return sayi % 2 == 0;
}
Console.Write("Bir sayı: ");
int tekmi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CiftMi(tekmi) ? "Çift" : "Tek");

Console.WriteLine("--------------------------------");

double AlinanYol(double hiz, double sure)
{
    return hiz * sure;
}
Console.WriteLine("saatteki 100km/sa olan bir araç 3 saatte ne kadar yol gider?");
Console.WriteLine(AlinanYol(100, 3) + "km");

Console.WriteLine("--------------------------------");

double DaireAlan(double yariCap)
{
    return Math.PI * yariCap * yariCap;
}

Console.Write("Yarıçap: ");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Alan: " + DaireAlan(r));

Console.WriteLine("--------------------------------");

string cumle = "Zaman bir GeRi SayIm";
Console.WriteLine(cumle.ToUpper());
Console.WriteLine(cumle.ToLower());

Console.WriteLine("--------------------------------");

string metin = "    Selamlar   ";
metin = metin.Trim();
Console.WriteLine(metin);

Console.ReadKey();