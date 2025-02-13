using ScreenSound_ASP.NET.Models;
using ScreenSound_ASP.NET.Repository;

namespace ScreenSound_ASP.NET.Menus;

internal class Menu
{
    public void DisplayOptionTitle(string title)
    {
        int letterCount = title.Length;
        string asterisks = string.Empty.PadLeft(letterCount, '*');
        Console.WriteLine(asterisks);
        Console.WriteLine(title);
        Console.WriteLine(asterisks + "\n");
    }

    public virtual void Execute(GenericRepository<Artist> repository)
    {
        Console.Clear();
    }
}
