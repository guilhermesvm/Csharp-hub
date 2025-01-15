float a = float.Parse(Console.ReadLine()!);
float b = float.Parse(Console.ReadLine()!);

void calculator(float A, float B)
{
    float sum = a + b;
    float sub = a - b;
    float mul = a * b;
    float div = a / b;

    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Sub: {sub}");
    Console.WriteLine($"Mul: {mul}");
    Console.WriteLine($"Div: {div}");
}

calculator(a, b);