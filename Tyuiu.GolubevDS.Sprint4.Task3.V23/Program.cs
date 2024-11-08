using Tyuiu.GolubevDS.Sprint4.Task3.V23.Lib;
DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #24                                                             *");
Console.WriteLine("* Выполнила: Голубев Дмитрий Сергеевч  | ИБКСб 24                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от 4 до 9, подсчитать сумму           *");
Console.WriteLine("* нечётных элементов массива.                                             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] array = new int[5, 5] { { 7, 5, 5, 6, 7 },
                                          { 8, 7, 8, 4, 3 },
                                          { 5, 6, 7, 8, 3 },
                                          { 4, 2, 3, 6, 4 },
                                          { 5, 2, 4, 2, 3 } };

int rows = array.GetUpperBound(0) + 1;
int columns = array.Length / rows;

Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
int count = ds.Calculate(array);
Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("Количество чётных элементов в массиве = " + count);


Console.ReadKey();
