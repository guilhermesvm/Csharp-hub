using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class Menu
{
    public void ShowOptionTitles(string title)
    {
        int chars = title.Length;
        string asterisks = string.Empty.PadLeft(chars + 1, '*');
        Console.WriteLine(asterisks);
        Console.WriteLine(title);
        Console.WriteLine(asterisks + "\n");
    }

    public virtual void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
    }
}
