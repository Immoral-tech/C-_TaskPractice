using C__TaskPractice.Tasks.Task1;
using C__TaskPractice.Tasks.Task2;
using C__TaskPractice.Tasks.Task3;


// Задание 1.1 Консольный ввод-вывод.
// Вариант 4. Данные ПК Модель процессора, объем ОЗУ (ГБ), наличие SSD (да/нет) Вывести системную спецификацию в верхнем регистре.
Info.WriteInfo();


// Задание 1.2 Приведение типов и парсинг.
// Вариант 4. Время в пути Расстояние (км), скорость (км/ч) Повторный запрос ввода до успеха.
Console.WriteLine($"Время в пути: {Parsing.CalculateTime()}");


// Задание 1.3 Работа с классом Math.
// Вариант 4. Синус и косинус угла Math.Sin, Math.Cos Предварительно перевести градусы в радианы.
Console.WriteLine("Введите угол для нахождения синуса и косинуса");
double gradus = Convert.ToDouble(Console.ReadLine());
CalculateSinCos.CalculateRadians(gradus);