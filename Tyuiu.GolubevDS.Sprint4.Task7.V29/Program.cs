using Tyuiu.GolubevDS.Sprint4.Task7.V29.Lib;
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

Console.WriteLine("Введите количество строк (n):");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов (m):");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите строку из одноразрядных цифр (длиной " + (n * m) + "):");
string value = Console.ReadLine();

try
{
    int result = ds.Calculate(n, m, value);
    Console.WriteLine("Сумма четных чисел в матрице: " + result);
}
catch (Exception ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}
Console.ReadLine();
