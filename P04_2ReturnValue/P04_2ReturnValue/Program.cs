// See https://aka.ms/new-console-template for more information
int playerVictories = 0;
int CPUwins = 0; 
int gameplayCounter = 0;

rockPaperOrScissors();
void rockPaperOrScissors()
{    
    Console.WriteLine($"Pick \n Rock \n Paper \n Scissors \n Or type Stop to stop gameloop.");
    string userInput = Console.ReadLine();
    int userValue = 0;
    string CPUInput = "";
    Random random = new Random(); 
    int CPUInputGenerator = random.Next(1, 4);
    
    //if statement declaring what random pick the CPU got
    if (CPUInputGenerator == 1) { CPUInput = "Rock"; } else if(CPUInputGenerator == 2){CPUInput = "Paper";} else if (CPUInputGenerator == 3) {CPUInput = "Scissors";}
    if (userInput == "Rock"){userValue = 1;}else if (userInput == "Paper"){userValue = 2;} else if(userInput == "Scissors"){userValue=3;} else if (userInput == "Stop"){return;} else{Console.WriteLine($"{userInput} is an invalid input.");}
    
    Console.WriteLine($"I picked {CPUInput}.");
    Console.WriteLine($"You picked {userInput}.");
    
    void CPUWin()
    {
    CPUwins++;
    gameplayCounter++;
    Console.WriteLine($"That's my win! \n CPU wins: {CPUwins}. \n Player wins {playerVictories}. \n Total games so far: {gameplayCounter}.");
    }
    void even()
    {
    gameplayCounter++;
    Console.WriteLine($"Looks like we're even \n CPU wins: {CPUwins}. \n Player wins {playerVictories}. \n Total games so far: {gameplayCounter}.");
    }
    void playerWin()
    {
    playerVictories++;
    gameplayCounter++;
    Console.WriteLine($"Looks like it's your win! \n CPU wins: {CPUwins}. \n Player wins {playerVictories}. \n Total games so far: {gameplayCounter}.");
    }
    
    
    if (userValue == 1 && CPUInputGenerator == 2){
        CPUWin();
    } else if (userValue == 1 && CPUInputGenerator == 1){
        even();
    } else if (userValue == 1 && CPUInputGenerator == 3){
        playerWin();
    } else if (userValue == 2 && CPUInputGenerator == 1){
        playerWin();
    } else if (userValue == 2 && CPUInputGenerator == 2){
        even();
    } else if (userValue == 2 && CPUInputGenerator == 3){
        CPUWin();
    } else if (userValue == 3 && CPUInputGenerator == 1){
        CPUWin();
    } else if (userValue == 3 && CPUInputGenerator == 2){
        playerWin();
    } else if (userValue == 3 && CPUInputGenerator == 3){
        even();
    }    
    Console.WriteLine("Play Again?");
    rockPaperOrScissors();
}


//part 2 of the assignment
Console.WriteLine("P04_2_1Numbers");

int Four(){return 4;}
int Five(){return 5;}

int fourResult = Four();
int fiveResult = Five();

int mathResults = fourResult + fiveResult;
Console.WriteLine($"{mathResults}");

//Part 3 of assignment
Console.WriteLine("P04_2_2UserInput");