// Показать четные числа от 1 до N
Console.Write("Enter a number: ");
int x = int.Parse(Console.ReadLine() ?? "0");
int i = 2;
while (i < x+1)
{
    Console.Write(i);
    Console.Write(", ");
    i = i+2;
}