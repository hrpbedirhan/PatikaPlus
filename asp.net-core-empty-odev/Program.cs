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
// ASP.NET Core MVC'de Controller, HTTP isteklerini karþýlayan sýnýftýr.
// Örneðin, `HomeController` bir sýnýf olabilir ve `Index()` metodu, 
// gelen HTTP isteðini iþleyip uygun bir View döndürebilir.

// Action:
// Controller içindeki bir metottur. Örneðin, `public IActionResult Index()` 
// gibi bir metot, bir HTTP isteðine karþýlýk gelen bir iþlevdir.

// Model:
// Uygulamanýzda veri yapýsýný temsil eden sýnýflardýr. Örneðin, 
// bir `Product` modeli, ürün bilgilerini tutabilir.

// View:
// Kullanýcýya sunulan HTML arayüzüdür. Razor dosyalarý (`.cshtml` dosyalarý) 
// kullanýlarak oluþturulur.

// Razor:
// ASP.NET Core'da HTML ile C# kodlarýný birleþtiren bir sayfa þablonlama dilidir.
// Razor kullanarak, View'lerde C# kodlarýný kullanabiliriz.

// RazorView:
// Razor þablon motoru tarafýndan render edilen View'dir.
// Örneðin, `Index.cshtml` bir Razor View olabilir ve HTML çýktýsý üretir.

// wwwroot:
// Statik dosyalarýn (CSS, JS, resimler vb.) saklandýðý klasördür. 
// Bu dosyalar `app.UseStaticFiles()` ile projeye dahil edilir.

// builder.Build():
// Uygulama yapýlandýrmasýný tamamlayýp, sunucuyu baþlatýr. 
// Tüm servis kayýtlarý tamamlandýktan sonra çaðrýlýr.

// app.Run():
// Uygulamayý çalýþtýrýr ve gelen istekleri dinlemeye baþlar. 
// Bu metot çaðrýldýktan sonra uygulama sonsuz döngüye girer ve 
// HTTP isteklerini karþýlamaya baþlar.
