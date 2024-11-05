using Tyuiu.GolubevDS.Sprint4.Task1.V12.Lib;
DataService ds = new DataService();

Console.WriteLine("**********************************************************************");
Console.WriteLine("* Спринт #4                                                          *");
Console.WriteLine("* Задание #1                                                         *");
Console.WriteLine("* Вариант #12                                                        *");
Console.WriteLine("**********************************************************************");
Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 13 элементов       *");
Console.WriteLine("* заполненный статическими значениями в диапазоне от 4 до 9          *");
Console.WriteLine("* подсчитать произведение нечетных элементов массива. С клавиатуры:  *");
Console.WriteLine("* {4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8}                            *");
Console.WriteLine("**********************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
Console.WriteLine("**********************************************************************");

int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] numArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    Console.Write("Введите значение " + i + " элемента массива: ");
    numArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine(numArray[i] + "\t");
}

Console.WriteLine();


Console.WriteLine("**********************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
Console.WriteLine("**********************************************************************");

int res = ds.Calculate(numArray);

Console.WriteLine($"Произведение нечётных элементов массива введённых с клавиатуры равна: {res}");

Console.ReadKey();