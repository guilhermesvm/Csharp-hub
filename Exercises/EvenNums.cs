List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var nums = numbers.Where(num => num % 2 == 0);

foreach (int num in nums)
{
    Console.WriteLine(num);
}