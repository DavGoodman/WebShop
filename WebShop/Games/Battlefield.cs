using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Interfaces;

namespace WebShop.Games
{
    internal class Battlefield : Game, IDigital
    {
      
        public Battlefield(int id = 1, string name = "Battlefield", int price = 150)
            : base(id, name, price)
        {
 
        }



    }
}
