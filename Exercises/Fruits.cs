List<string> fruits = new List<string> { "Apple", "Banana", "Pear", "Orange", "Strawberry", "Watermelon" };

for (int i = 0; i < fruits.Count; i++)
{
    Console.WriteLine($"| " + i + " | " + fruits[i]);

}

Console.Write("Choose your favorite fruit by typing its ID: ");
int op = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Your favorite fruit is {fruits[op]}.");
