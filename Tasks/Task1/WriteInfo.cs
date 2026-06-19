namespace C__TaskPractice.Tasks.Task1
{
    public class Info
    {
        public static void WriteInfo()
        {
            // Ввод данных
            Console.Write("Введите модель процессора: ");
            string? cpu = Console.ReadLine();
            Console.Write("Введите объем ОЗУ ");
            int ram = int.Parse(Console.ReadLine());
            Console.Write("SSD есть? да/нет ");
            string? ssd = Console.ReadLine();

            // Вывод данных
            Console.WriteLine($"Процессор: {cpu.ToUpper()}");
            Console.WriteLine($"ОЗУ: {ram}");
            Console.WriteLine($"ССД: {ssd.ToUpper()}");
        }
    }
}
