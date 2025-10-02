using Tyuiu.LyapinSE.Sprint1.Task5.V4.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h)            *");
Console.WriteLine("* прошло к этому моменту (например, h=3, если k=13257).                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int k;

Console.WriteLine("Введите k:");
k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double result = ds.SecondsToHours(k);
Console.WriteLine($"Полных часов = {result}");

Console.ReadLine();