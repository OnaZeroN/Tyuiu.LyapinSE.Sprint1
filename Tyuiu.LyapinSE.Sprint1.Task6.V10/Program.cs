using Tyuiu.LyapinSE.Sprint1.Task6.V10.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Работа со строками класс String                                   *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
Console.WriteLine("* Напечатать все слова, удалив среднюю букву у слов нечетной длины.      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Введите текст:");
string value = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string result = ds.DeleteMiddleLetter(value);
Console.WriteLine($"Текст = {result}");

Console.ReadLine();