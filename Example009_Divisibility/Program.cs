Console.Write("Enter a first number (divisible, делимое): ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter a second number (divider, делитель): ");
int y = int.Parse(Console.ReadLine());
int r = x%y;

if (r == 0)
{
    Console.Write("The number IS a multiple of the entered number (кратно)");
}
else
{
    Console.WriteLine("The number ISN't a multiple of the entered number (некратно)");
    Console.Write("The remainder of the division = ");
    Console.Write(r); 
}