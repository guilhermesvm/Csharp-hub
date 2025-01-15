Dictionary<string, int> stock = new Dictionary<string, int>();
stock.Add("bass", 5);
stock.Add("guitar", 10);
stock.Add("drums", 2);
stock.Add("keyboard", 12);

Console.Write("Choose an stock item to check its quantity: ");
string item = Console.ReadLine()!;

if (stock.ContainsKey(item))
{
    int quantity = stock[item];
    Console.WriteLine($"{item} quantity is {quantity}");
}
else
{
    Console.WriteLine("This item doesn't exist in our stock.");
}

