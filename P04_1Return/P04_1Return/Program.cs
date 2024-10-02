// See https://aka.ms/new-console-template for more information

Console.WriteLine("P04_1Return");
MyFunction(); //calls myfunction function 

void MyFunction()
{
    Console.WriteLine("Hello, what's your name?");
    string name = Console.ReadLine();
    if (name == "neo" || name == "Neo" || name == "nEo")
    {
        Console.WriteLine($"Hello, {name}!");
        age(); //calls age function
        return;
    }
    MyFunction();
    
    void age()
    {
        Console.WriteLine("What is your age?");
        int years = int.Parse(Console.ReadLine());
        if (years < 18)
        {
            age();
        }
        if (years >= 18)
        {
            proceedToEnter();
        }
        
        void proceedToEnter(){
            Console.WriteLine($"{name} do you wish to enter?"); 
            string enter = Console.ReadLine();
            if (enter != "yes")
            {
                proceedToEnter();
                return;
            }
            Console.WriteLine("Congratulations, you made it in.");
        }
    }
}

//part 2 of assignment
Console.WriteLine("P04_1_1BuyGamePls");

Console.WriteLine("Do you wish to buy a game?");

int loop = 0;

while (loop < 1)
{
    string buyGame = Console.ReadLine();
    if (buyGame == "no")
    {
        buyGamePls();
    } else if (buyGame == "yes")
    {
        Console.WriteLine("Thank you");
        loop++; 
    }
    else
    {
        Console.WriteLine($"Not valid input");
        return; 
    }
}

void buyGamePls()
{
    Console.WriteLine("Please buy a game.");
}

//assignment part 3
Console.WriteLine("P04_1_2Countdown");
int timer = 5;
countdown();
void countdown()
{
    if (timer < 0)
    {
        return;
    }
    
    Console.WriteLine(timer);
    timer--;
    countdown();
}


//assignment part 4
Console.WriteLine("P04_1_3MakeTheMessageAppear");

void MagicMessage(){
    Console.WriteLine("You're trying to find the magic message.");
    // Replace this comment with code.
    goto Magic;
    return;
    Magic:
    Console.WriteLine("You found the magic message.");
}
MagicMessage();