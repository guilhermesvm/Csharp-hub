using ScreenSound_ASP.NET.Models;
using ScreenSound_ASP.NET.Repository;

namespace ScreenSound_ASP.NET.Menus;

internal class MenuExit : Menu
{
    public override void Execute(ArtistRepository artistRepository)
    {
        Console.WriteLine("Goodbye :)");
    }
}
