using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
    public class ShopController : Controller
    {
        //create your initial list to begin with 
        private static List<Item> items
            = new List<Item>()
            {
                new Item(){Code = "1234", Description = "Dyson Hoover", Price = 425},
                new Item(){Code = "1452", Description = "Case of Beer", Price = 14},
                new Item(){Code = "1755", Description = "Nilfisk", Price = 125},
                new Item(){Code = "2258", Description = "Cuddly Toy", Price = 30}
            };

        //setup our Cart
        private Cart cart = new Cart();

        // GET: ShopController
        public ActionResult Index()
        {
            return View(items);
        }

        // GET: ShopController/Details/5
        public ActionResult Add(string code)
        {
            Item itm = items.FirstOrDefault(i => i.Code.ToUpperInvariant() == code.ToUpperInvariant());
            if(itm != null)
            {
                cart.AddItem(itm);
            }
            return View();
        }

       
    }
}
