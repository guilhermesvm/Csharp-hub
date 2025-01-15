//ScreenSound

Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>();
registeredBands.Add("Blink-182", new List<int>() { 10, 10, 9, 5});
registeredBands.Add("Linkin Park", new List<int>());

void ShowMenuOptions()
{
   Console.Clear();
   Console.WriteLine("Welcome To ScreenSound\n");
   Console.WriteLine("Type 1 to register a band");
   Console.WriteLine("Type 2 to show all bands");
   Console.WriteLine("Type 3 to give ratings to a band");
   Console.WriteLine("Type 4 to whatever");
   Console.WriteLine("Type -1 to sign off. \n");

   Console.Write("Type your option: ");
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
           Console.WriteLine("Você escolheu a opção " + op);
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
   ShowOptionTitles("Band Register");
   Console.Write("Type in the band's name you want to register: ");
   string bandName = Console.ReadLine()!;
   registeredBands.Add(bandName, new List<int>());

   Console.WriteLine($"Band: '{bandName}' was successfully registered.");
   Thread.Sleep(2500);
   ShowMenuOptions();
}

void ShowBands()
{
   Console.Clear();
   ShowOptionTitles("Showing All Registered Bands");

   foreach (string band in registeredBands.Keys)
   {
       Console.WriteLine($"Band: {band}");
   }

   Console.WriteLine("\nPress any key to show the menu options.");
   Console.ReadKey();
   ShowMenuOptions();
}

void RateBands() 
{
   Console.Clear();
   ShowOptionTitles("Rating Your Favorite Band!");

   Console.Write("Choose a band to rate: ");
   string bandName = Console.ReadLine()!;

   if(registeredBands.ContainsKey(bandName))
   {
       Console.Write($"Give your rating to {bandName}: ");
       int rating = int.Parse(Console.ReadLine()!);
       registeredBands[bandName].Add(rating);
       Console.WriteLine("\nYour rating was registered successfully.");
       Thread.Sleep(2500);
       Console.Clear();
       ShowMenuOptions();
   }
   else
   {
       Console.WriteLine($"\nBand {bandName} was not found.");
       Console.WriteLine("Press any key to show the menu options.");
       Console.ReadKey();
       ShowMenuOptions();
   }
}

void ShowOptionTitles(string title)
{
   int chars = title.Length;
   string asterisks = string.Empty.PadLeft(chars + 1, '*');
   Console.WriteLine(asterisks);
   Console.WriteLine(title);
   Console.WriteLine(asterisks + "\n");
}


