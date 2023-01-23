using WebShop.Interfaces;

namespace WebShop.Games;

internal class PUBG : Game, IPhysical, IDigital
{
    public PUBG(int id = 4, string name = "PUBG", int price = 100)
        : base(id, name, price)
    {

    }



}