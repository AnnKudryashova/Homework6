﻿//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >0)
    {
        result +=1;
    }
}

Console.WriteLine("Количество чисел > 0: " + result);
