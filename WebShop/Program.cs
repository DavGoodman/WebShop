
using WebShop;
using WebShop.Games;
using WebShop.Interfaces;

StoreInventory Inventory = new StoreInventory();
while (true)
{
    Console.WriteLine("Welcome to the shop! ");
    Console.WriteLine("1: Show all available games");
    Console.WriteLine("2: Show only physical games");
    Console.WriteLine("3: Show only downloadable games");

    HandleCommand();
}

void HandleCommand()
{
    string command = Console.ReadLine();
    Inventory.PrintInventory(command);
    Console.WriteLine("input the ID of game you want to buy");

    var gameID = Console.ReadLine();
    Game gameToBuy = Inventory.InventoryList.Find(x => x.Id.ToString() == gameID);
    if(gameToBuy == null) return;
    ShoppingCart.Add(gameToBuy);

    //Sjekk på om spillet skal shippes eller lastes ned
    if (gameToBuy is IDigital) PrintDownloadMessage(gameToBuy.Name);
    else if (gameToBuy is IPhysical) PrintShippingMessage(gameToBuy.Name);

    //Print ut med Download eller shipping metoden under
    void PrintDownloadMessage(string gameName)
    {
        Console.WriteLine($"Game {gameName} will now be downloaded..");
    }

    void PrintShippingMessage(string gameName)
    {
        Console.WriteLine($"Game {gameName} will be shipped shortly..");
    }
}