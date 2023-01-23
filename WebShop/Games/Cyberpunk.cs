using WebShop.Interfaces;

namespace WebShop.Games;

internal class Cyberpunk : Game, IPhysical, IDigital
{
    public Cyberpunk(int id = 2, string name = "Cyberpunk", int price = 250)
        : base(id, name, price)
    {

    }



}