﻿using System;
using Tyuiu.GolubevDS.Sprint4.Task6.V10.Lib;
DataService ds = new DataService();
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #4                                                                    *");
Console.WriteLine("* Тема: Класс Array                                                            *");
Console.WriteLine("* Задание #6                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Дан строковый массив данных ['Театр', 'Кино', 'Музей', 'Парк', 'Зоопарк',    *");
Console.WriteLine("* 'Концерт', 'Выставка'], используя класс Array, выведите элементы массива,    *");
Console.WriteLine("* длина которых меньше 7 символов.                                             *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

var words = new string[] { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
Console.WriteLine("Исходный массив: ");
for (int i = 0; i <= words.Length - 1; i++)
{
    Console.WriteLine(words[i]);
}

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("Элементы массива, длина которых меньше 7: ");

string[] res = ds.Calculate(words);
for (int i = 0; i <= res.Length - 1; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();