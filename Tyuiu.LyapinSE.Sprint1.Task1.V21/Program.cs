using Tyuiu.LyapinSE.Sprint1.Task1.V21.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя                  *");
Console.WriteLine("* исходные данные, вычисляет результат по формуле (x*y)/(3+y)             *");
Console.WriteLine("* и печатает его на экране.                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double a, x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double result = ds.Calculate(x, y);
Console.WriteLine($"{result:F2}");

Console.ReadLine();