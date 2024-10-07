// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input a number and I'll give you the fibonacci of said number");

int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Fibonacci({n}) = {Fibonacci(n)}");

static long Fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

//part 2 of assignment

Console.WriteLine("P05_0_FirstParam");

void input(string s)
{
    Console.WriteLine(s);
}

input("Marc");
input("Game Programming");
input("Forsbergs");
