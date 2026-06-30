using C__TaskPractice.Tasks.Task1;
using C__TaskPractice.Tasks.Task2;
using C__TaskPractice.Tasks.Task3;
using C__TaskPractice.Tasks.Task4;
using C__TaskPractice.Tasks.Task5;
using C__TaskPractice.Tasks.Task6;
using C__TaskPractice.Tasks.Task7;
using C__TaskPractice.Tasks.Task8;
using C__TaskPractice.Tasks.Task9;
using C__TaskPractice.Tasks.Task10;
using C__TaskPractice.Tasks.Task11;


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


// Задание 2.1 Циклы и генерация последовательностей
// Вариант 4 Арифметическая прогрессия Старт = X, шаг = Y, N элементов Накапливать сумму элементов в переменную
Task4.GenerationNumbers();

// Задание 2.2 Условные конструкции и ветвление
// Вариант 4 Оценка успеваемости Балл от 0 до 100 Использовать if-else if для градаций (A, B, C...)
GradeNumber.Ball();


// Задание 2.3 Работа с одномерными и двумерными
// Вариант 4 Двумерный (n x n) Вычислить сумму элементов на главной диагонали Использовать один цикл for
SumDiagonal.Sum();


// Задание 3.1 Классы, свойства и инкапсуляция
// Вариант 4 SensorData Температура (в диапазоне от -50 до +50) Инициализация автосвойств значениями по умолчанию
Console.WriteLine("Демонстрация класса SensorData\n");

// Конструктор по умолчанию
SensorData sensor1 = new SensorData();
Console.WriteLine("Сенсор 1 (по умолчанию):");
Console.WriteLine(sensor1);
Console.WriteLine();

// Конструктор с параметрами
SensorData sensor2 = new SensorData(25.5, 65.0, "Лаборатория 1");
Console.WriteLine("Сенсор 2 (с параметрами):");
Console.WriteLine(sensor2);
Console.WriteLine();

// Конструктор с минимальными параметрами
SensorData sensor3 = new SensorData(-10.0);
Console.WriteLine("Сенсор 3 (минимальный конструктор):");
Console.WriteLine(sensor3);
Console.WriteLine();

// Проверка валидации
try
{
    Console.WriteLine("Попытка установить недопустимую температуру:");
    sensor1.Temperature = 100.0;
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}


// Задание 3.2 Наследование и полиморфиз
// Вариант 4 Vehicle (Транспорт) Car, Bicycle Move()
Console.WriteLine("Демонстрация полиморфизма\n");

Vehicle[] vehicles = new Vehicle[]
{
                new Car("Tesla Model 3", "Красный", 450, 4),
                new Bicycle("Турист", "Синий", 21, true),
                new Car("BMW X5", "Черный", 333, 5),
                new Bicycle("Горный", "Зеленый", 18, false)
};

Console.WriteLine("Все транспортные средства в движении:\n");
foreach (var vehicle in vehicles)
{
    vehicle.ShowInfo();
    vehicle.Move();
    vehicle.Stop();

    // Проверка на Bicycle для дополнительного метода
    if (vehicle is Bicycle bicycle)
    {
        bicycle.RingBell();
    }

    Console.WriteLine();
}

Console.WriteLine("Сравнение скорости\n");
Vehicle car = new Car("Sport Car", "Желтый", 500, 2);
Vehicle bike = new Bicycle("Скоростной", "Серебристый", 24, true);

Console.WriteLine("Гонка:");
car.Move();
bike.Move();

Console.WriteLine($"\nПобедитель: {(car.Speed > bike.Speed ? "Автомобиль" : "Велосипед")}");


// Задание 3.3 Интерфейс
// Вариант 4 IStorage DatabaseStorage, CloudStorage Save(data), Load(id)
IStorage[] storages = new IStorage[]
{
            new DatabaseStorage(),
            new CloudStorage("MyBucket")
};

foreach (var storage in storages)
{
    Console.WriteLine($"\n{storage.GetType().Name}");

    // Сохраняем данные
    storage.Save("Первые данные");
    storage.Save("Вторые данные");

    // Загружаем данные
    var data = storage.Load(1);
    Console.WriteLine($"Загружено: {data}");

    // Удаляем данные
    storage.Delete(1);

    // Проверяем удаление
    var deleted = storage.Load(1);
    Console.WriteLine($"После удаления: {deleted}");
}



// Задание 4.1 Использование стандартных делегатов
// Вариант 4 Массив цен (decimal) Func<decimal, decimal> Применить налог к каждой цене
decimal[] prices = { 100.50m, 200.00m, 50.75m, 300.25m };

var processor = new PriceProcessor();

// Применяем налог 20%
decimal[] pricesWithTax = processor.ApplyTax(prices, p => p * 1.2m);

Console.WriteLine("Цены с налогом 20%:");
foreach (var price in pricesWithTax)
{
    Console.WriteLine($"{price:F2}");
}

// Применяем налог 10%
decimal[] pricesWithVAT = processor.ApplyTax(prices, p => p * 1.1m);
Console.WriteLine("\nЦены с налогом 10%:");
foreach (var price in pricesWithVAT)
{
    Console.WriteLine($"{price:F2}");
}


// Задание 4.2 Пользовательские события (Events
// Вариант 4 Sensor Превышение порога температуры CoolingSystem (запускает охлаждение)
// Создаём сенсор с порогом 30°C
Sensor temperatureSensor = new Sensor(30);

// Создаём систему охлаждения и подписываемся
CoolingSystem cooling = new CoolingSystem();
cooling.Subscribe(temperatureSensor);

temperatureSensor.CurrentTemperature = 25;
temperatureSensor.CurrentTemperature = 28;
temperatureSensor.CurrentTemperature = 32;
temperatureSensor.CurrentTemperature = 29;
temperatureSensor.CurrentTemperature = 35;

// Отписка
cooling.Unsubscribe(temperatureSensor);