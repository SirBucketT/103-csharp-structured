// See https://aka.ms/new-console-template for more information

Console.WriteLine("P8_1RandomNumbers");
Console.WriteLine("Here is 13 random numbers (1-6):");

Random random = new Random();

for (int i = 0; i < 13; i++)
{
    int number;
    number = random.Next(1, 7);
    Console.Write(number);
}
