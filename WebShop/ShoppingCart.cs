using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Games;

namespace WebShop
{
    internal class ShoppingCart
    {
        public static List<Game> CartItems = new List<Game>();


        public static void Add(Game game)
        {
            CartItems.Add(game);
        }
    }
}
