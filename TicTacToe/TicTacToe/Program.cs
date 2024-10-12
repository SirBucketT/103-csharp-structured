// See https://aka.ms/new-console-template for more information

string[] piles = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
int PlayerWin = 0;
int AIWin = 0;

printPiles();

void printPiles()
{
    for (int i = 0; i < 3; i++) //prints out the top part of the sticks for each pile
    {
        Console.WriteLine($" {piles[i * 3]} | {piles[i * 3 + 1]} | {piles[i * 3 + 2]} "); 
        
    }
}
Console.WriteLine("Tic-Tac-Toe Game, on input press the number you wish to play");


string input = Console.ReadLine;
piles = input.Split(" ");


playerWinCondition();
void playerWinCondition(){
    if (piles[0] == "X" && piles[1] == "X" && piles[2] == "X")
    {
        Console.WriteLine("Player wins!");
        PlayerWin++;
    } else if (piles[3] == "X" && piles[4] == "X" && piles[5] == "X")
    {
        Console.WriteLine("Player wins!");
        PlayerWin++;
    } else if (piles[6] == "X" && piles[7] == "X" && piles[8] == "X")
    {
        Console.WriteLine("Player wins!");
        PlayerWin++;
    } else if (piles[0] == "X" && piles[4] == "X" && piles[8] == "X")
    {
        Console.WriteLine("Player wins!");
        PlayerWin++;
    } else if (piles[6] == "X" && piles[4] == "X" && piles[2] == "X")
    {
        Console.WriteLine("Player wins!");
        PlayerWin++;
    } else if (piles[0] == "X" && piles[3] == "X" && piles[6] == "X")
    {
        Console.WriteLine("Player wins!");
        PlayerWin++;
    }
    else if (piles[2] == "X" && piles[5] == "X" && piles[8] == "X")
    {
        Console.WriteLine("Player wins!");
        PlayerWin++;
    }
} 

AIWinCondition();
void AIWinCondition(){
    if (piles[0] == "O" && piles[1] == "O" && piles[2] == "O")
    {
        Console.WriteLine("Player wins!");
        AIWin++;
    } else if (piles[3] == "O" && piles[4] == "O" && piles[5] == "O")
    {
        Console.WriteLine("Player wins!");
        AIWin++;
    } else if (piles[6] == "O" && piles[7] == "O" && piles[8] == "O")
    {
        Console.WriteLine("Player wins!");
        AIWin++;
    } else if (piles[0] == "O" && piles[4] == "O" && piles[8] == "O")
    {
        Console.WriteLine("Player wins!");
        AIWin++;
    } else if (piles[6] == "O" && piles[4] == "O" && piles[2] == "O")
    {
        Console.WriteLine("Player wins!");
        AIWin++;
    } else if (piles[0] == "O" && piles[3] == "O" && piles[6] == "O")
    {
        Console.WriteLine("Player wins!");
        AIWin++;
    }
    else if (piles[2] == "O" && piles[5] == "O" && piles[8] == "O")
    {
        Console.WriteLine("Player wins!");
        AIWin++;
    }
} 