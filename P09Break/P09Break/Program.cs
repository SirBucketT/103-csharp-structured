// See https://aka.ms/new-console-template for more information

int health = 10;

while (health > 0)
{
    Console.WriteLine("Select how many lives you want to take.");
    
    string playerTakes = Console.ReadLine();
    if (playerTakes == "Stop" || playerTakes == "stop")
    {
        goto endGame;
    }
    int amount = int.Parse(playerTakes);
    
    int damage = health - amount;
    health = damage;
    
    Console.WriteLine(health);
    
    if (health == 0)
    {
        break;
    }
}
endGame:
Console.WriteLine("Game finnished");