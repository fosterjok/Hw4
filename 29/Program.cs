﻿/*Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int [] array;
array= CreateArray();
for (int i = 0; i < array.Length; i++)
  Console.Write($"{array[i] }");

int [] CreateArray()
{
int [] _array= new int [8];
    for (int i = 0; i < 8; i++)
 _array[i]= new Random().Next(0,10);
 return _array;
}