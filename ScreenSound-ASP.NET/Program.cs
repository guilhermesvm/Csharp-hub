using ScreenSound_ASP.NET.Menus;
using ScreenSound_ASP.NET.Models;
using ScreenSound_ASP.NET.Infrastructure;
using ScreenSound_ASP.NET.Repository;

ScreenSoundContext context = new ScreenSoundContext();
var repository = new GenericRepository<Artist>(context);

Dictionary<int, Menu> options = new();
options.Add(1, new MenuRegisterArtist());
options.Add(2, new MenuRegisterSong());
options.Add(3, new MenuShowArtists());
options.Add(4, new MenuShowSongs());
options.Add(5, new MenuShowSongsByYear());
options.Add(0, new MenuExit());

void DisplayMenuOptions()
{
    Console.WriteLine("Enter 1 to register an artist");
    Console.WriteLine("Enter 2 to register a song for an artist");
    Console.WriteLine("Enter 3 to show all artists");
    Console.WriteLine("Enter 4 to display all songs of an artist");
    Console.WriteLine("Enter 5 to display all songs by release year");
    Console.WriteLine("Enter 0 to exit");

    Console.Write("\nEnter your choice: ");
    string chosenOption = Console.ReadLine()!;
    int chosenOptionNumeric = int.Parse(chosenOption);

    if (!options.ContainsKey(chosenOptionNumeric))
    {
        Console.WriteLine("Invalid option");
    }
    Menu menuToDisplay = options[chosenOptionNumeric];
    menuToDisplay.Execute(repository);

    if (chosenOptionNumeric > 0)
    {
        DisplayMenuOptions();
    }
}

DisplayMenuOptions();
