# Müşteri ve Sipariş Bilgilerini Görüntüleme - ASP.NET Core MVC Projesi

Bu proje, **ASP.NET Core MVC** kullanarak basit bir müşteri ve sipariş görüntüleme uygulamasıdır. Proje, MVC tasarım desenini kullanarak bir müşteri ve bu müşterinin siparişlerini listelemektedir. Uygulama, müşteri bilgilerini ve sipariş bilgilerini bir view model ile birlikte gösterir.


## Proje Adımları

### Aşama 1: Model Oluşturma

Proje için iki ana model oluşturulmuştur:

1. **Customer Modeli**:
   - **Id**: Müşterinin benzersiz kimliği (int).
   - **FirstName**: Müşterinin adı (string).
   - **LastName**: Müşterinin soyadı (string).
   - **Email**: Müşterinin e-posta adresi (string).

2. **Order Modeli**:
   - **Id**: Siparişin benzersiz kimliği (int).
   - **ProductName**: Ürünün adı (string).
   - **Price**: Ürünün fiyatı (decimal).
   - **Quantity**: Sipariş edilen ürün miktarı (int).

### Aşama 2: ViewModel Oluşturma

- **CustomerOrderViewModel** sınıfı oluşturulmuştur. Bu sınıf, müşteri bilgilerini ve müşteri siparişlerinin listesini içerir:
    - **Customer**: Müşteri bilgilerini tutan bir `Customer` nesnesi.
    - **Orders**: Müşteriye ait siparişleri tutan bir liste (`List<Order>`).

### Aşama 3: Controller Oluşturma

1. **CustomerOrdersController** sınıfı oluşturulmuştur ve bu controller içinde `Index` adında bir aksiyon metodu bulunmaktadır. Bu metod:
   - Örnek bir müşteri nesnesi ve birkaç sipariş nesnesi oluşturur.
   - Bu nesneleri kullanarak bir `CustomerOrderViewModel` nesnesi oluşturur.
   - `CustomerOrderViewModel` nesnesini view'a iletir.

2. **HomeController** sınıfı oluşturulmuş olup, varsayılan olarak `Index` metoduna sahiptir.

### Aşama 4: View Oluşturma

1. **Views/CustomerOrders/Index.cshtml** dosyasında, `CustomerOrderViewModel` kullanarak müşteri bilgileri ve siparişler listelenir. 
    - Müşteri adı, soyadı, e-posta bilgileri ve sipariş tablosu görüntülenir.

2. **_Layout.cshtml** dosyasına bir navbar eklenmiş ve navbar'a "Müşteri ve Siparişler" butonu eklenmiştir. Bu buton, `CustomerOrders` sayfasına yönlendiren bir bağlantıyı içerir.

### Aşama 5: Layout Güncelleme

- **_Layout.cshtml** dosyasına navbar eklenmiş ve her sayfada görünmesi sağlanmıştır.
- Navbar'a **Müşteri ve Siparişler** butonu eklenmiştir, bu buton tıklandığında `CustomerOrders` sayfasına yönlendirme yapılmaktadır.

## Çalıştırma

Projeyi çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. Visual Studio veya Visual Code üzerinde projeyi açın.
2. Terminal veya komut istemcisinde aşağıdaki komutu çalıştırarak proje bağımlılıklarını yükleyin:

    ```bash
    dotnet restore
    ```

3. Projeyi başlatmak için aşağıdaki komutu çalıştırın:

    ```bash
    dotnet run
    ```

4. Tarayıcınızda `http://localhost:5000` adresine giderek uygulamayı görebilirsiniz.

## Kullanıcı Arayüzü

Proje, **Müşteri Bilgileri** ve **Siparişler** başlıkları altında aşağıdaki bilgileri göstermektedir:

- **Müşteri Bilgileri**:
    - İsim
    - Soyisim
    - E-posta adresi

- **Siparişler**:
    - Sipariş ID
    - Ürün adı
    - Fiyat
    - Miktar

## Teknolojiler

- **ASP.NET Core MVC**: Model-View-Controller tasarım desenini kullanarak web uygulamaları geliştirmeye olanak sağlar.
- **Bootstrap**: Sayfanın görünümünü iyileştirmek için kullanılan popüler CSS framework'ü.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır.
