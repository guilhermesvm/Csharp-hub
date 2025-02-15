﻿namespace ScreenSound_ASP.NET.Models;

public class Song
{
    public Song(string name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; } 
    public int? ReleaseYear  { get; set; }
    public virtual Artist? Artist { get; set; }

    public void DisplayTechnicalDetails()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Name: {Name}";
    }
}
