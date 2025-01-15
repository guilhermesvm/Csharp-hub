Dictionary<string, string> loginDatabase = new Dictionary<string, string>();
loginDatabase.Add("guilherme", "guilherme13");
loginDatabase.Add("markus", "markus123");

while (true)
{
    Console.WriteLine("Login");
    Console.Write("Type in your username: ");
    string username = Console.ReadLine()!;

    if (!loginDatabase.ContainsKey(username))
    {
        Console.WriteLine("There's no match for your username.");
        continue;
    }

    Console.Write("Type in your password: ");
    string password = Console.ReadLine()!;

    if (password != loginDatabase[username])
    {
        Console.WriteLine("Invalid password.");
        continue;
    }
    Console.WriteLine($"Welcome Mr/Ms.{username}.");
    break;
}