/* Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int a;
Console.Write("Введите число А: ");
int.TryParse(Console.ReadLine()!, out a);

int b;
Console.Write("Введите число D: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write($" {Function(a,b)} ");
int Function (int _a, int _b)

{
    int function=_a;
for (int i = 1; i < _b; i++)

    function = function*a;
    return function;
}