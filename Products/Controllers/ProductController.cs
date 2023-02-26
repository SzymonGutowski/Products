using Microsoft.AspNetCore.Mvc;
using Products.Models;

namespace Products.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {

            Product product = new Product
            {
                Id= 1,
                Description= "Black",
                Name = "Car",
                Price = 100
            };


            return View(product); 
        }

        public IActionResult ProductList() 
        {
            var products = new List<Product>
            {
                new Product
                {
                Id= 1,
                Description= "Black",
                Name = "Car",
                Price = 100
                },
                  new Product
                {
                Id= 2,
                Description= "Apple",
                Name = "Food",
                Price = 1
                },
                    new Product
                {
                Id= 3,
                Description= "Boeing",
                Name = "Airplane",
                Price = 100000000
                },                 
            
            };
            products.Add(new Product { });
            return View(products);
        }
    
        public IActionResult Details()
        {
            ViewBag.Name = "Tomek";
            ViewData["Surname"] = "Atomek";
            TempData["SecondName"] = "Romek";

            
            return View();
        }

    
    }

}
