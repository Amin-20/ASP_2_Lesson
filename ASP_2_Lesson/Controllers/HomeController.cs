using ASP_2_Lesson.Entities;
using ASP_2_Lesson.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_2_Lesson.Controllers
{
    public class HomeController : Controller
    {
        public  List<Product> Products { get; set; } = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Bread",
                Category = "FlourProducts",
                Price = 1.5,
                Discount = 10,
                ImagePath="https://images.squarespace-cdn.com/content/v1/637d515697f2794487fadba3/1678986214708-5LDWY9SQAF7AY1X3N11A/krusty_roll.png?format=1500w"
            },
            new Product
            {
                Id = 2,
                Name = "Lays",
                Category = "CipsProducts",
                Price = 3,
                Discount = 15,
                ImagePath = "https://www.bigbasket.com/media/uploads/p/xxl/294283_18-lays-potato-chips-spanish-tomato-tango.jpg"
            },
            new Product
            {
                Id = 3,
                Name = "Red Bull",
                Price = 4,
                Category = "EnergyDrinks",
                Discount = 15,
                ImagePath = "https://bazarstore.az/cdn/shop/products/30011102_1000x.png?v=1693894488"
            },
            new Product
            {
                Id = 4,
                Name = "Sobranie",
                Price = 4.3,
                Category="SmokeProduct",
                Discount = 15,
                ImagePath = "https://bravomarket.online/upload/iblock/a37/a373b371c691f7578f8c0752f9198399.png"
            }
        };

        public IActionResult Index()
        {
            var ProductVM = new ProductViewModel
            {
                Products = Products
            };
            return View(ProductVM);
        }
    }
}
