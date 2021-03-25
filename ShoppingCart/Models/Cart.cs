using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Cart
    {
        //Adding to a list for each item in the cart
        //We do not want an entry for each item - one entry for an item with the qty included
        //e.g. 2 oranges would be 1 entry not two seperate entries
        private List<CartItem> items;

        public Cart()
        {
            items = new List<CartItem>();
        }

        public void AddItem(Item choice)
        {
            //Check that the item is not in the list already
            //ToUpperInvarient means it will look for upper and lower case
            CartItem found = items.FirstOrDefault(p => p.Code.ToUpperInvariant() == choice.Code.ToUpperInvariant());
            if(found != null)
            {
                found.Qty++; //if its found - increase the quantity already in the cart
            }
            else //if its not found - we add it
            {
                items.Add(new CartItem() { Code = choice.Code, Description = choice.Description, Price = choice.Price, Qty = 1 });
            }

        }
        //method for calculating the total in the cart
        public double CalcTotal()
        {
            //using Generic Collections makes this easy
            //by using the generic collections we dont need a large loop code here
            return items.Sum(p => p.Price * p.Qty);
        }

    }
}
