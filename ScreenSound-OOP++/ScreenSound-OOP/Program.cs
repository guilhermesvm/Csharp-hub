using ScreenSound.Menus;
using ScreenSound.Models;

Band sabaton = new Band("Sabaton");
sabaton.AddRating(new Rating(10), new Rating(8), new Rating(6));
sabaton.AddAlbum(new Album("ww2"));

Band theBeatles = new Band("The Beatles");

Dictionary<string, Band> registeredBands = new Dictionary<string, Band>();
registeredBands.Add(sabaton.Name, sabaton);
registeredBands.Add(theBeatles.Name, theBeatles);

Dictionary<int, Menu> options = new Dictionary<int, Menu>();
options.Add(1, new MenuRegisterBand());
options.Add(2, new MenuShowBands());
options.Add(3, new MenuRateBand());
options.Add(4, new MenuShowBandDetails());
options.Add(5, new MenuRegisterAlbum());
options.Add(6, new MenuRateAlbum());

void ShowMenuOptions()
{
    Console.Clear();
    Console.WriteLine("Welcome To ScreenSound\n");
    Console.WriteLine("Type 1 to register a band");
    Console.WriteLine("Type 2 to show all bands");
    Console.WriteLine("Type 3 to rate a band");
    Console.WriteLine("Type 4 to show a band's details");
    Console.WriteLine("Type 5 to register an album");
    Console.WriteLine("Type 6 to rate an album");
    Console.WriteLine("Type -1 to sign off. \n");
    Console.Write("Enter your option: ");

    int op = int.Parse(Console.ReadLine()!);
    if (!options.ContainsKey(op))
    {
        Console.WriteLine("Invalid option.");
    }

    Menu menuTobeShown = options[op];
    menuTobeShown.Execute(registeredBands);

    if (op > 0) ShowMenuOptions();
}

ShowMenuOptions();