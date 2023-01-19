// Показать вторую цифру трёхзначного числа
Console.Write("Enter a three-digit number: ");
int x = int.Parse(Console.ReadLine());
int y = x%10; //остаток от деления на 10
int z = x%100; //остаток от деления на 100
int r = (z - y)/10;
Console.Write(r);