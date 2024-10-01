// See https://aka.ms/new-console-template for more information

int timer = 5;
countdown(timer);
    void countdown(int timer)
    {
   
         if (timer > 0)
            {
                Console.WriteLine($"{timer}");
                countdown(timer - 1);
            }
        
        
        }




Console.WriteLine("P03_2FunctionPuzzle");

void F1(){
    Console.Write("A"); // A
}
void F2(){
    Console.Write("B"); // BA
    F1();
}
void F3(){
    F1();
    Console.Write("-"); // A-BA
    F2();
}
void F4(){
    Console.Write("-"); // -A
    F1();
}


F2(); F3(); F2(); F4(); F1(); F1(); F4(); F3(); F2();
Console.WriteLine();

Console.WriteLine("P03_1Triangle");
int triangleInput = int.Parse(Console.ReadLine());


DrawTriangle(triangleInput);
void DrawTriangle(int triangleInput)
{
    if (triangleInput > 0)
    {
        for (int i = 0; i < triangleInput; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine();

            //recursive mcThing
        DrawTriangle(triangleInput - 1);
    }
}