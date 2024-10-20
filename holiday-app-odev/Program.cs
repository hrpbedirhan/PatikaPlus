bool holiday = true;

while (holiday)
{
    string location = "";
    int person = 0;
    int price = 0;
    int totalPrice = 0;

    // lokasyon seçimi yapan döngü
    while (true)
    {
        Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçin: Bodrum, Marmaris, Çeşme");
        location = Console.ReadLine().ToLower();

        if (location == "bodrum" || location == "marmaris" || location == "çeşme")
        {
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz lokasyon seçimi. Lütfen Bodrum, Marmaris veya Çeşme yazınız.");
        }
    }

    // kişi sayısı için olan döngü
    while (true)
    {
        Console.Write("Kaç kişi için tatil planlıyorsunuz? ");
        if (int.TryParse(Console.ReadLine(), out person) && person > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
        }
    }

    // ulaşım seçimi için olan döngü
    while (true)
    {
        Console.WriteLine("Nasıl gitmek istersiniz?");
        Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı 1500 TL)");
        Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı 4000 TL)");
        Console.Write("Seçiminiz (1/2): ");
        string ulasimSecimi = Console.ReadLine();

        if (ulasimSecimi == "1")
        {
            price = 1500 * person;
            break;
        }
        else if (ulasimSecimi == "2")
        {
            price = 4000 * person;
            break;
        }
        else
        {
            Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 olarak seçim yapınız.");
        }
    }

    // lokasyonlara göre toplam fiyat
    if (location == "bodrum")
    {
        totalPrice = 4000 + price;
    }
    else if (location == "marmaris")
    {
        totalPrice = 3000 + price;
    }
    else if (location == "çeşme")
    {
        totalPrice = 5000 + price;
    }

    // tatil için gidilecek yerin baş harfini büyük yapma
    location = char.ToUpper(location[0]) + location.Substring(1).ToLower();
    
    // tatil bilgilerini yazdırma
    Console.WriteLine($"\nTatil Bilgileri:");
    Console.WriteLine($"Lokasyon: {location}");
    Console.WriteLine($"Kişi sayısı: {person}");
    Console.WriteLine($"Ulaşım Tutarı: {price} TL");
    Console.WriteLine($"Toplam Fiyat: {totalPrice} TL\n");

    // tekrar tatil planı yapılacaksa döngü devam edecek
    Console.Write("Başka bir tatil planlamak ister misiniz? (E/H): ");
    string tekrar = Console.ReadLine().ToLower();

    if (tekrar != "e")
    {
        holiday = false;
        Console.WriteLine("İyi günler! Tatil uygulamamızı kullandığınız için teşekkürler.");
    }
}

Console.ReadKey();