Console.Write("Enter a number: ");
int x = int.Parse(Console.ReadLine());
if (x < 100)
{
    Console.Write("The third digit of the number IS OUT (отсутствует)");
}
else
{
    while (x > 999)
    {
        x = x/10;
    }
    int z = x%10;
    Console.Write("The third digit of the number = ");
    Console.Write(z);
}