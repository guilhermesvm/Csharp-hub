﻿using ScreenSound_ASP.NET.Models;
using ScreenSound_ASP.NET.Repository;

namespace ScreenSound_ASP.NET.Menus;

internal class MenuShowSongs : Menu
{
    public override void Execute(GenericRepository<Artist> repository)
    {
        base.Execute(repository);
        DisplayOptionTitle("Display Artist Details");
        
        Console.Write("Enter the name of the artist you want to know more about: ");
        string artistName = Console.ReadLine()!;

        Artist artist = repository.GetBy(a => a.Name.Equals(artistName));
        if (artist == null)
        {
            Console.WriteLine($"\nThe artist {artistName} was not found!");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
            return;       
        }
        
        artist.DisplayDiscography();
        Console.WriteLine("\nPress any key to return to the main menu");
        Console.ReadKey();
        Console.Clear();
    }
}
