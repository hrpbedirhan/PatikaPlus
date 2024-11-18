# ASP.NET Core Empty Proje

Bu proje, **ASP.NET Core Empty** bir proje oluşturulup MVC (Model-View-Controller) tasarım desenine uygun olarak yapılandırılmıştır. Bu proje ile temel olarak, ASP.NET Core MVC özelliklerini kullanarak, proje yapısının nasıl oluşturulacağı ve yapılandırılacağı anlatılmaktadır.

## Proje Yapısı

Aşağıda proje yapısında kullanılan ana klasörler ve dosyalar listelenmiştir:

### 1. **Controllers**
   - **Controllers** klasörü, MVC tasarım deseninde kullanıcı isteklerini karşılayan ve işlemleri yönlendiren sınıfların bulunduğu alandır.
   - Bu klasörde **HomeController.cs** gibi controller sınıfları yer alacaktır.

### 2. **Models**
   - **Models** klasörü, uygulamanın iş mantığına göre veri yapılarını tanımlayan sınıfları içerir. Veritabanı modelleri, view model'leri ve benzeri iş sınıfları burada bulunur.

### 3. **Views**
   - **Views** klasörü, Razor View dosyalarını içerir. Bu dosyalar HTML, C# kodu ve verileri dinamik olarak birleştiren dosyalardır.
   - Burada, her bir controller'ın aksiyonları için uygun View dosyaları yer alacaktır.

### 4. **wwwroot**
   - **wwwroot** klasörü, uygulamanın statik dosyalarını içerir. Bu dosyalar arasında JavaScript, CSS, resimler gibi dosyalar bulunur.
   - Statik dosyalar bu klasör içerisinde yönetilecektir.
