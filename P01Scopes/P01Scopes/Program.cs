// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number.");
{
    string input = Console.ReadLine();
    int increment = 0;
    increment++;
    Console.WriteLine($"{input}{increment}");
}
{
    Console.WriteLine("Give me another number.");
    
    int input = int.Parse(Console.ReadLine());
    input++;
    Console.WriteLine(input);
}
{
    Console.WriteLine("Give me another number.");
    
    char input = Convert.ToChar(Console.ReadLine());
    input++;
    Console.WriteLine(input);
}