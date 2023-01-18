Console.Write("Enter a number: ");
int x = int.Parse(Console.ReadLine());
int i = 2;
while (i < x+1)
{
    Console.Write(i);
    Console.Write(", ");
    i = i+2;
}