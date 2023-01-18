Console.Write("Enter a number from 10 to 99: ");
int x = int.Parse(Console.ReadLine());
int y = x%10; //остаток от деления на 10, второе число
int z = (x-y)/10; //первое число
if (z>y)
{
    Console.Write("The max number is = ");
    Console.Write(z);
}
else
{
    Console.Write("The max number is = ");
    Console.Write(y);
}