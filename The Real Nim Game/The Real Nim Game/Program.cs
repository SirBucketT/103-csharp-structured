// See https://aka.ms/new-console-template for more information

Console.WriteLine("The real Nim game.\n The rules are quite simply, draw a number sticks between 1-3 from one of the pile rows.\n  Whoever draws the last stick from all piles loses");

Random row = new Random();
Random amount  = new Random();

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
} 

Console.WriteLine("Select which pile you want to draw from.");

pileSelection(piles);
void pileSelection(int[] ints)
{
    int stickDrawn;
    int pile = int.Parse(Console.ReadLine());
    
    if (pile < 1 || pile > 3) //makes player choose which pile they want to draw from and prints error if pile doesn't exist
    {
        Console.WriteLine("That pile does not exist, try again.");
        pileSelection(piles);
    } else if (pile == 1)
    {
        Console.WriteLine("How many sticks do you wish to draw from pile?");
        stickDrawn = int.Parse(Console.ReadLine());
        
        if (stickDrawn < 1 || stickDrawn > 3)
        {
            Console.WriteLine("Can't draw more then 3 sticks or less then 1 stick from pile 1");
            pileSelection(piles);
        }
        
        ints[0] -= stickDrawn;
    }else if (pile == 2)
    {
        Console.WriteLine("How many sticks do you wish to draw from pile?");
        stickDrawn = int.Parse(Console.ReadLine());
        
        if (stickDrawn < 1 || stickDrawn > 3)
        {
            Console.WriteLine("Can't draw more then 3 sticks or less then 1 stick from pile 1");
            pileSelection(piles);
        }
        
        ints[1] -= stickDrawn;
    }  else if (pile == 3)
    {
        Console.WriteLine("How many sticks do you wish to draw from pile?");
        stickDrawn = int.Parse(Console.ReadLine());
        
        if (stickDrawn < 1 || stickDrawn > 3)
        {
            Console.WriteLine("Can't draw more then 3 sticks or less then 1 stick from pile 1");
            pileSelection(piles);
        }
        
        ints[2] -= stickDrawn;
    }
    
}
printPiles();