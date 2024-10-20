Console.WriteLine("Bilgi Yarışmasına Hoş Geldiniz..");
Console.WriteLine("Sizden soracağımız sorulara doğru olduğunu düşündüğünüz cevabı vermenizi istiyoruz.");
Console.WriteLine("Hazırsanız ilk sorunuz geliyor.");

// Sorular ve cevapları lise içinde tuttum
List<string> sorular = new List<string>
            {
                "1 -> Kızınca tüküren hayvan hangisidir ?\na) Lama b) Deve",
                "2 -> Dünya'ya en yakın gezegen hangisidir ?\na) Venüs b) Mars",
                "3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? \na) 7 b) 12"
            };

List<char> dogruCevaplar = new List<char> { 'a', 'a', 'b' };

int point = 0;

// Soruları sırayla sormak için for kullandım
for (int i = 0; i < sorular.Count; i++)
{
    Console.WriteLine(sorular[i]);
    Console.Write("Cevabınız (a/b): ");
    char answer = Console.ReadLine().ToLower()[0];

    // Cevabı kontrol et
    if (answer == dogruCevaplar[i])
    {
        Console.WriteLine("Doğru cevap!");
        point ++; // Her doğru cevapla puan arttırılır
    }
    else
    {
        Console.WriteLine("Yanlış cevap!");
    }
    Console.WriteLine();
}

string message =  point >= 2 ? "Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!" : "Üzgünüm! Yarışmayı kaybettiniz.";

Console.WriteLine(message);
Console.ReadKey();