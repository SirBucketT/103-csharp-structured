// See https://aka.ms/new-console-template for more information

Console.WriteLine("P05_2_0FullName");

Console.WriteLine("Hello what is your first name?");
string firstNameInput = Console.ReadLine();

Console.WriteLine("And your last name?");
string lastNameInput = Console.ReadLine();

Console.WriteLine("Hello, ");
firstName(firstNameInput); Console.Write(" ");
lastName(lastNameInput);

void firstName(string f)
{
    Console.Write(f);
}

void lastName(string l)
{
    Console.Write(l);
}

//Next Assignment
/* Write a function that takes two integer arguments and prints the average of both numbers. Test it with the following arguments:

2, 6
0, 10
-12, 12
11, 9
*/ 

Console.WriteLine("P05_2_1Average");

Console.WriteLine("Give me a number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Give me another number and I'll tell you the average of them");
int num2 = int.Parse(Console.ReadLine());
int result = 0;

avNum(num1, num2, result);

void avNum(int num1, int num2, int result)
{
    result = num1 + num2 / 2;
    Console.WriteLine(result);
}

//Next part of assignment 

/*Write a function that takes two integer arguments and prints the first argument to the power of the second number. Test it with the following arguments:

3, 2
5, 1
2, 5
2, 10
19, 0
13, 1
*/ 

Console.WriteLine("P05_2_2Power");


Console.WriteLine("Give me a number");
int powNum1 = int.Parse(Console.ReadLine());

Console.Write(" Give me another number to do the power of");
int powNum2 = int.Parse(Console.ReadLine());

powNum(powNum1, powNum2);

void powNum(int powNum1, int powNum2)
{
    double powResult = Math.Pow(powNum1, powNum2);
    Console.WriteLine(powResult);
}


//Next Part
Console.WriteLine("P05_2_3NextDoubleBetween");

//Write a function that takes to double arguments and prints a random number between the first argument (inclusive) and the second argument (exclusive). Figure out a way of testing the function.


Console.WriteLine("Give me two numbers and I'll give you a random numbers between them \n number 1:");

double randNum1 = double.Parse(Console.ReadLine());
Console.Write($"{randNum1} noted, now provide number 2");
double randNum2 = double.Parse(Console.ReadLine());
Console.Write($"Generating a random between {randNum1} and {randNum2} with {randNum2} excluded ");

randNumGenerator(randNum1, randNum2);

void randNumGenerator(double randNum1, double randNum2)
{
    Random random = new Random();

    if (randNum1 > randNum2)
    {
        Console.WriteLine("Wrong numbers input");
        return; 
    }

    double randResult = random.NextDouble() * (randNum2 - randNum1) + randNum1;
    Console.WriteLine(randResult);
}

//final part
Random numberGuess = new Random();

int guess = numberGuess.Next(1, 51);
int guess2 = numberGuess.Next(51, 100);
Console.WriteLine("I want you to guess a number between two numbers I've generated, I will loop as long as your guess is incorrect");

void guessingGame(int guess, int guess2)
{
    
}


