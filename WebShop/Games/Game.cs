using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Games
{
    internal class Game
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Price { get; protected set; }

        protected Game(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {Name} Price: {Price} ID: {Id}");
        }
    }
}
