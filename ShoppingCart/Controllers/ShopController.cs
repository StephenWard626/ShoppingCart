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
        //Everytime a request comes in the below code will create a new instance of Cat
        //private Cart cart = new Cart();
        //We make it static to avoid this
        private static Cart cart = new Cart();

        // GET: ShopController
        public ActionResult Index()
        {
            //The ViewBag will update the total price each time it is ran
            ViewBag.TotalPrice = cart.CalcTotal();
            return View(items);
        }

        // GET: ShopController/Details/5
        public ActionResult Add(string code)
        {
            Item itm = items.FirstOrDefault(i => i.Code.ToUpperInvariant() == code.ToUpperInvariant());
            if(itm != null)
            {
                //Add item if it is not null and return to the Index View
                cart.AddItem(itm);
                //return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

       
    }
}
