// Удалить вторую цифру трёхзначного числа
Console.Write("Enter a three-digit number: ");
int x = int.Parse(Console.ReadLine() ?? "0");
int c = x%10; //остаток от деления на 10, третья цифра
int z = x%100; //остаток от деления на 100
int b = (z - c)/10; //вторая цифра
int a = (x - z)/100; //первая цифра
Console.Write(a); 
Console.Write(c); 