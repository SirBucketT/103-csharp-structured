// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
AskNumberBetween();
void AskNumberBetween()
{
    int min = 1;
    int max = 3;
    int value = 0;

    int nextNumber = 0;
    do
    {
       Console.WriteLine($"Please give me a number between {min} and {max}."); 
       value = int.Parse(Console.ReadLine());
       if (value >= min && value <= max)
       {
           nextNumber++;
       }
    }
    while (nextNumber != 1);
    {
        Console.WriteLine($"You gave number {value}.");
        min = 41;
        max = 103;
        
        do
        {
            Console.WriteLine("Please give me a number between 41 and 103."); 
            value = int.Parse(Console.ReadLine());
            if (value >= min && value <= max)
            {
                nextNumber++;
            }
            
        }
        while (nextNumber != 2);
        {
            Console.WriteLine($"You gave number {value}.");
        }
    }
}