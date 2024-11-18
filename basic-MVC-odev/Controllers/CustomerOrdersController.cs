using basic_MVC_odev.Models;
using Microsoft.AspNetCore.Mvc;

namespace basic_MVC_odev.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek müşteri verisi
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                Email = "ahmet.yilmaz@example.com"
            };

            // Örnek siparişler
            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 2000, Quantity = 1 },
                new Order { Id = 2, ProductName = "Telefon", Price = 1500, Quantity = 2 },
                new Order { Id = 3, ProductName = "Tablet", Price = 500, Quantity = 1 }
            };

            // ViewModel oluşturma
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // View'a gönderme
            return View(viewModel);
        }
    }
}
