using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Item
    {
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

    }

    public class CartItem: Item
    {
        public int Qty { get; set; }
    }
}
