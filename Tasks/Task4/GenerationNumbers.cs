namespace C__TaskPractice.Tasks.Task4
{
    public class Task4
    {
        public static void GenerationNumbers()
        {
            Console.WriteLine("Арифметическая прогрессия");

            Console.Write("Введите начальное значение X: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Введите шаг Y: ");
            int Y = int.Parse(Console.ReadLine());

            Console.Write("Введите количество элементов N: ");
            int N = int.Parse(Console.ReadLine());

            long sum = 0;
            int current = X;

            Console.WriteLine($"\nАрифметическая прогрессия (старт={X}, шаг={Y}, N={N}):");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{current} ");
                sum += current;
                current += Y;
            }

            Console.WriteLine($"\nСумма элементов: {sum}");

            long expectedSum = N * (2L * X + (N - 1L) * Y) / 2;
            Console.WriteLine($"Проверка по формуле: {expectedSum}");
        }
    }
}
