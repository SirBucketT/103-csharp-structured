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