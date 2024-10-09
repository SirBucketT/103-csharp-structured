// See https://aka.ms/new-console-template for more information

int powerOfStart = 1;

// for (int i = 0; i < 11; i++)
// {
//     Console.Write($"{powerOfStart}-");
//     int powerOf = 2;
//     int powerOfResult = (int)Math.Pow(powerOfStart, powerOf);
//     powerOfStart = powerOfResult;
//     
//     int powerOfLoop = 2;
//     int powerOfTimes = powerOfStart;
//     powerOfStart = powerOfTimes * powerOfLoop;

//}
Console.Write($"{powerOfStart}");

for (int i = 0; i < 10; i++){
    int result = powerOfStart * 2;
    
    powerOfStart = result;
    Console.Write($"-{powerOfStart}");
}