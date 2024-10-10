// See https://aka.ms/new-console-template for more information

Console.WriteLine("The real Nim game.\n The rules are quite simply, draw a number sticks between 1-3 from one of the pile rows.\n  Whoever draws the last stick from all piles loses");

int AIwins = 0;
int PlayerWins = 0;

int[] piles = { 3, 4, 5 };

printPiles();

void printPiles()
{
    for (int i = 0; i < piles.Length; i++) //prints out the top part of the sticks for each pile
    {
        Console.WriteLine(new string('0', piles[i])); 
        Console.WriteLine(new string('|', piles[i]));
        Console.WriteLine();
    }
} //loop that prints out sticks into the console

pileSelection(piles);
void pileSelection(int[] ints)
{
    int stickDrawn;
    Console.WriteLine("Select which pile you want to draw from.");
    int pile = int.Parse(Console.ReadLine());
    
    void drawer(){
        if (stickDrawn < 1 || stickDrawn > 3)
        {
            Console.WriteLine("Can't draw more then 3 sticks or less then 1 stick from pile");
            pileSelection(piles);
        }
    }
    
    if (pile < 1 || pile > 3) //makes player choose which pile they want to draw from and prints error if pile doesn't exist
    {
        Console.WriteLine("That pile does not exist, try again.");
        pileSelection(piles);
    } else if (pile == 1)
    {
        Console.WriteLine("How many sticks do you wish to draw from pile?");
        stickDrawn = int.Parse(Console.ReadLine());
        
        drawer();
        
        ints[0] -= stickDrawn;
        
    } else if (pile == 2)
    {
        Console.WriteLine("How many sticks do you wish to draw from pile?");
        stickDrawn = int.Parse(Console.ReadLine());
        
        drawer();
        
        ints[1] -= stickDrawn;
        
    } else if (pile == 3)
    {
        Console.WriteLine("How many sticks do you wish to draw from pile?");
        stickDrawn = int.Parse(Console.ReadLine());
        
        drawer();
        
        ints[2] -= stickDrawn;
    }
    
    
    if (ints[0] < 1 && ints[1] < 1 && ints[2] < 1)
    {
        AIwins++; 
        Console.WriteLine($"AI wins. \n AI wins {AIwins}");
        
    } //AI win condition
    printPiles();
}

AIturn(piles);
void AIturn(int[] ints)
{
    Random AI = new Random();
    
    if (ints[0] < 1 && ints[1] < 1 && ints[2] < 1) //player wins condition
    {
        PlayerWins++; 
        Console.WriteLine($"Player wins. \n Player wins {AIwins}");
    }
}