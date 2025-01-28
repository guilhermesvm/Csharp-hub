//ScreenSound

Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>();
registeredBands.Add("Blink-182", new List<int>() { 10, 10, 9, 5 });
registeredBands.Add("Linkin Park", new List<int>());

void ShowMenuOptions()
{
    Console.Clear();
    Console.WriteLine("Welcome To ScreenSound\n");
    Console.WriteLine("Type 1 to register a band");
    Console.WriteLine("Type 2 to show all bands");
    Console.WriteLine("Type 3 to rate a band");
    Console.WriteLine("Type 4 to view band's average rating");
    Console.WriteLine("Type -1 to sign off. \n");

    Console.Write("Enter your option: ");
    int op = int.Parse(Console.ReadLine()!);

    switch (op)
    {
        case 1:
            BandRegister();
            break;
        case 2:
            ShowBands();
            break;
        case 3:
            RateBands();
            break;
        case 4:
            ShowBandsAverageRating();
            break;
        case -1:
            Console.WriteLine("See ya! :)");
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}

ShowMenuOptions();

void BandRegister()
{
    Console.Clear();
    ShowOptionTitles("Band Registration");
    Console.Write("Enter the name of the band you want to register: ");
    string bandName = Console.ReadLine()!;
    registeredBands.Add(bandName, new List<int>());

    Console.WriteLine($"Band: '{bandName}' was successfully registered.");
    Thread.Sleep(2000);
    ShowMenuOptions();
}

void ShowBands()
{
    Console.Clear();
    ShowOptionTitles("All Registered Bands");

    foreach (string band in registeredBands.Keys)
    {
        Console.WriteLine($"Band: {band}");
        Console.WriteLine($"Band Rating: {registeredBands[band]}");
    }

    Console.WriteLine("\nPress any key to return to the menu.");
    Console.ReadKey();
    ShowMenuOptions();
}

void RateBands()
{
    Console.Clear();
    ShowOptionTitles("Rate Your Favorite Band!");

    Console.Write("Choose a band to rate: ");
    string bandName = Console.ReadLine()!;

    if (registeredBands.ContainsKey(bandName))
    {
        Console.Write($"Enter your rating for {bandName}: ");
        int rating = int.Parse(Console.ReadLine()!);
        registeredBands[bandName].Add(rating);
        Console.WriteLine("\nYour rating has been successfully registered .");
        Thread.Sleep(2500);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"\nBand {bandName} was not found.");
        Console.WriteLine("\nPress any key to return to the menu.");
        Console.ReadKey();
    }

    ShowMenuOptions();
}

void ShowBandsAverageRating()
{
    Console.Clear();
    ShowOptionTitles("View Favorite Band's Average Rating");

    Console.Write("Choose a band to see its average rating: ");
    string bandName = Console.ReadLine()!;
    if (!registeredBands.ContainsKey(bandName))
    {
        Console.WriteLine($"Band {bandName} was not found.\n");
        Console.WriteLine("\nPress any key to return to the menu.");
        Console.ReadKey();
        ShowMenuOptions();
    }

    double rating = registeredBands[bandName].Average();
    if (rating <= 0)
    {
        Console.WriteLine($"Band {bandName} has not been rated yet.");
    }
    else
    {
        Console.WriteLine($"The average rating for the band {bandName} is {rating:F2}.");
    }

    Thread.Sleep(2500);
    Console.Clear();
    ShowMenuOptions();

}

void ShowOptionTitles(string title)
{
    int chars = title.Length;
    string asterisks = string.Empty.PadLeft(chars + 1, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

