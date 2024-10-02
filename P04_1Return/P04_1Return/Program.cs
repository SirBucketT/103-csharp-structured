// See https://aka.ms/new-console-template for more information

Console.WriteLine("P04_1Return");
Console.WriteLine("Hello, what's your name?");

MyFunction(); //calls myfunction function 

void MyFunction()
{
    string name = Console.ReadLine();
    if (name == "neo" || name == "Neo" || name == "nEo")
    {
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine("What is your age?");
        age(); //calls age function

        return;
    }
    
//if name does not = neo he will be denied entry
Console.WriteLine($"You're not Neo, you're {name}. Begone {name}!");
return;
    
    void age()
    {
        int years = int.Parse(Console.ReadLine());
        if (years >= 18)
        {
            Console.WriteLine($"{name} do you wish to enter?");
            string enter = Console.ReadLine();
            if (enter != "yes")
            {
                Console.WriteLine("Are you sure you don't wish to enter the dungeon?");
                string enter2 = Console.ReadLine();
                if (enter2 == "yes")
                {
                    Console.WriteLine("Congratulations, you made it in.");
                }
            } else
            {
                Console.WriteLine($"{name} do you wish to turn back?");
                string exit = Console.ReadLine();
                if (exit != "yes")
                {
                    Console.WriteLine("Congratulations, you made it in.");
                }
            }
        }
        
        else // if neo is below 18 he will be denied entry
        {
            Console.WriteLine("you shall not pass");
        }
    }
}

//part 2 of assignment
Console.WriteLine("P04_1_1BuyGamePls");



Console.WriteLine("Do you with to buy a game?");

int loop = 0;

while (loop < 1)
{
    string buyGame = Console.ReadLine();
    if (buyGame != "yes")
    {
        buyGamePls();
    } else if (buyGame == "yes")
    {
        Console.WriteLine("Thank you");
        loop++;
    }
}

void buyGamePls()
{
    Console.WriteLine("Please buy a game.");
}
Console.WriteLine("P04_1_2Countdown");