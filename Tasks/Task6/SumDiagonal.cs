namespace C__TaskPractice.Tasks.Task6
{
    public class SumDiagonal
    {
        public static void Sum()
        {
            Console.WriteLine("Сумма элементов на главной диагонали");
            Console.Write("Введите размер квадратной матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random random = new Random();

            Console.WriteLine($"\nИсходная матрица {n}x{n}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine($"\nСумма элементов на главной диагонали: {sum}");
            Console.Write("Диагональные элементы: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matrix[i, i]} ");
            }
            Console.WriteLine();
        }
    }
}
