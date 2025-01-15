Random random = new Random();
int randomNumber = random.Next(1, 101);

Console.WriteLine("A random number was generated. Guess it!");
int count = 0;

do
{

    int guess = int.Parse(Console.ReadLine()!);
    count++;

    if (guess == randomNumber)
    {
        Console.WriteLine($"You got it right! You had {count} attempts.");
        break;
    }
    else if (guess < randomNumber)
    {
        Console.WriteLine("Hint! Number is higher.");
    }
    else
    {
        Console.WriteLine("Hint! Number is lower.");
    }
} while (true);
