// Выяснить является ли число чётным
Console.Write("Enter a number: ");
int x = int.Parse(Console.ReadLine());
int r = x%2; //остаток от деления на 2

if (r==1)
{
    Console.Write("The number is odd (число нечетное)");
}
else
{
    Console.Write("The number is even (Число четное)");
}