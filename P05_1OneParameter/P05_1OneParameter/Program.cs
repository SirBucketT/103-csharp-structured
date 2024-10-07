﻿// See https://aka.ms/new-console-template for more information

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

//Part 3 of the assignment
Console.WriteLine("P05_1_1Double");
/* Write a function that takes one integer parameter. It prints double the value to the console. Invoke the function with the following arguments: */

void doubleOutput(int v)
{
    Console.WriteLine(v * 2);
}

doubleOutput(5);
doubleOutput(-2);
doubleOutput(0);
doubleOutput(100);
doubleOutput(1_000_000_000);
doubleOutput(2_000_000_000);