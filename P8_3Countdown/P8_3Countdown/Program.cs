// See https://aka.ms/new-console-template for more information

Console.WriteLine("P8_3Countdown");
Console.WriteLine("I'm counting down!");

int countdown = 10;

for (int i = 0; i < 11; i++)
{
    Console.Write($"{countdown}..");
    countdown--;
}