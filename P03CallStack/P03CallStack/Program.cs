// See https://aka.ms/new-console-template for more information
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
//BAA-BABBA-AAA-AA-BAB
//BAA-BABBA-AAA-AA-BAB
F2(); F3(); F2(); F4(); F1(); F1(); F4(); F3(); F2();