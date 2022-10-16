/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int a;
Console.Write("Введите число А: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($" {Sum(a)} ");
int Sum(int _a)
{
    int sum=0;
    int s= _a;
    while (s>0)
    {sum= sum + s%10;
    s= s/10;}
    return sum;
 
}