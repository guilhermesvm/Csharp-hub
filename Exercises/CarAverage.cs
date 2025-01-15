Dictionary<string, List<int>> carSales = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

while (true)
{
    Console.Write("Choose a car to calculate the average price: ");
    string car = Console.ReadLine()!;

    if (string.IsNullOrEmpty(car) || !carSales.ContainsKey(car))
    {
        Console.WriteLine("Please enter a valid car name.");
        continue;
    }

    double average = carSales[car].Average();
    Console.WriteLine($"The average for the car {car} is ${average:F2}");
    break;
}
