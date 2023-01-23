using WebShop.Interfaces;

namespace WebShop.Games;

internal class PokemonLetsGoEevee : Game, IPhysical
{
    public PokemonLetsGoEevee(int id = 3, string name = "Pokemon Let's GO Eevee", int price = 400)
        : base(id, name, price)
    {

    }



}