Console.Write("Enter a number1: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter a number2: ");
int y = int.Parse(Console.ReadLine());
int square = y * y;
if (square == x)
{
    Console.Write("The first number IS the square of the second");
}
else
{
     Console.Write("The first number ISN't the square of the second");
}