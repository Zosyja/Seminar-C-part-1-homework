// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Enter a number1: ");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter a number2: ");
int y = int.Parse(Console.ReadLine() ?? "0");
int square = y * y;
if (square == x)
{
    Console.Write("The first number IS the square of the second (является)");
}
else
{
     Console.Write("The first number ISN't the square of the second (не является)");
}