using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Games;
using WebShop.Interfaces;

namespace WebShop
{
    internal class StoreInventory
    {
        public List<Game> InventoryList;

        public StoreInventory()
        {
            InventoryList = new List<Game>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEevee());
            InventoryList.Add(new Cyberpunk());
            InventoryList.Add(new Battlefield());
        }

        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDigitalItems());
            }
        }

        private void Print(List<Game> inventory)
        {
            foreach (var game in inventory)
            {
                game.PrintGameNameAndPrice();
            }
        }

        public List<Game> ListPhysicalItems()
        {
            return InventoryList.Where(GameItem => GameItem is IPhysical).ToList();
        }
        public List<Game> ListDigitalItems()
        {
            return InventoryList.Where(GameItem => GameItem is IDigital).ToList();
        }
    }
}
