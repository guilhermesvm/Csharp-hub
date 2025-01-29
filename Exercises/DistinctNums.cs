List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1 };
var distinctNums = numbers.Distinct().ToList();

foreach (int num in distinctNums)
{
    Console.WriteLine(num);
}