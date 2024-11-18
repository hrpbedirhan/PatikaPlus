using Microsoft.AspNetCore.Mvc;

namespace asp.net_core_empty_odev
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

// Controller:
// ASP.NET Core MVC'de Controller, HTTP isteklerini kar��layan s�n�ft�r.
// �rne�in, `HomeController` bir s�n�f olabilir ve `Index()` metodu, 
// gelen HTTP iste�ini i�leyip uygun bir View d�nd�rebilir.

// Action:
// Controller i�indeki bir metottur. �rne�in, `public IActionResult Index()` 
// gibi bir metot, bir HTTP iste�ine kar��l�k gelen bir i�levdir.

// Model:
// Uygulaman�zda veri yap�s�n� temsil eden s�n�flard�r. �rne�in, 
// bir `Product` modeli, �r�n bilgilerini tutabilir.

// View:
// Kullan�c�ya sunulan HTML aray�z�d�r. Razor dosyalar� (`.cshtml` dosyalar�) 
// kullan�larak olu�turulur.

// Razor:
// ASP.NET Core'da HTML ile C# kodlar�n� birle�tiren bir sayfa �ablonlama dilidir.
// Razor kullanarak, View'lerde C# kodlar�n� kullanabiliriz.

// RazorView:
// Razor �ablon motoru taraf�ndan render edilen View'dir.
// �rne�in, `Index.cshtml` bir Razor View olabilir ve HTML ��kt�s� �retir.

// wwwroot:
// Statik dosyalar�n (CSS, JS, resimler vb.) sakland��� klas�rd�r. 
// Bu dosyalar `app.UseStaticFiles()` ile projeye dahil edilir.

// builder.Build():
// Uygulama yap�land�rmas�n� tamamlay�p, sunucuyu ba�lat�r. 
// T�m servis kay�tlar� tamamland�ktan sonra �a�r�l�r.

// app.Run():
// Uygulamay� �al��t�r�r ve gelen istekleri dinlemeye ba�lar. 
// Bu metot �a�r�ld�ktan sonra uygulama sonsuz d�ng�ye girer ve 
// HTTP isteklerini kar��lamaya ba�lar.
