// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, there is 10 Matches! \n You can draw up to three sticks per turn.");

int sticks = 10;

while (sticks > 0)
{
    Console.WriteLine("Enter a number of sticks you wish to draw.");
    int userDrawnSticks = int.Parse(Console.ReadLine());
    
    if (userDrawnSticks > 3)
    {
        Console.WriteLine("you may not draw more then three sticks");
        return; 
    }

    int sticksLeft = sticks;
    sticks = sticksLeft - userDrawnSticks;

    Console.WriteLine($"{sticks} remain");

    if (sticks == 0)
    {
        Console.WriteLine("Game Over");
    }
}