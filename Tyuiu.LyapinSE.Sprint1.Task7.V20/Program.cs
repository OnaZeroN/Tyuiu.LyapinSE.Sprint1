using Tyuiu.LyapinSE.Sprint1.Task7.V20.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринт                  *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("*     2 + cos^2(x + y)                                                    *");
Console.WriteLine("* z = ———————————-———————————-—————————— + xy                             *");
Console.WriteLine("*     1 + | x - (3x / (1 + (x^2 * y^2))) |                                *");
Console.WriteLine("***************************************************************************");


double x, y;

Console.WriteLine("Введите x:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double result = ds.Calculate(x, y);
Console.WriteLine($"Резултат = {result}");

Console.ReadLine();