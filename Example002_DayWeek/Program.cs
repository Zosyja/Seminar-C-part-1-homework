// По заданному номеру дня недели вывести его название
Console.Write("Enter number day of week (from 1 to 7): ");
int x = int.Parse(Console.ReadLine());

if (x==1)
{
    Console.Write("Monday (понедельник)");
}
else if(x==2)
{
    Console.Write("Tuesday (вторник)");
}
else if(x==3)
{
    Console.Write("Wednesday (среда)");
}
else if(x==4)
{
    Console.Write("Thursday (четверг)");
}
else if(x==5)
{
    Console.Write("Friday (пятница)");
}
else if(x==6)
{
    Console.Write("Saturday (суббота)");
}
else
{
    Console.Write("Sunday (воскресенье)");
}