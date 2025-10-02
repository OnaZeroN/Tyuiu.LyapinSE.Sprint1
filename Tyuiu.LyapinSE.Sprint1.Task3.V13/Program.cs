using Tyuiu.LyapinSE.Sprint1.Task3.V13.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя                  *");
Console.WriteLine("* исходные данные, выполняет указанные расчёты и печатает результат       *");
Console.WriteLine("* на экране.                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double value;

Console.WriteLine("Введите трехзначное число:");
value = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double result = ds.MultiplyOfDigits(value);
Console.WriteLine($"Произведение цифр заданного трехзначного числа = {result}");

Console.ReadLine();