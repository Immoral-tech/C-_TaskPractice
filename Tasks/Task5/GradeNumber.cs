namespace C__TaskPractice.Tasks.Task5
{
    public class GradeNumber
    {
        public static void Ball()
        {
            Console.WriteLine("Оценка успеваемости");
            Console.Write("Введите балл (0-100): ");

            int score = int.Parse(Console.ReadLine());

            if (score < 0 || score > 100)
            {
                Console.WriteLine("Ошибка: балл должен быть в диапазоне от 0 до 100!");
                return;
            }

            char grade;
            string description;

            if (score >= 90)
            {
                grade = 'A';
                description = "Отлично";
            }
            else if (score >= 80)
            {
                grade = 'B';
                description = "Хорошо";
            }
            else if (score >= 70)
            {
                grade = 'C';
                description = "Удовлетворительно";
            }
            else if (score >= 60)
            {
                grade = 'D';
                description = "Ниже среднего";
            }
            else if (score >= 50)
            {
                grade = 'E';
                description = "Минимальный проходной";
            }
            else
            {
                grade = 'F';
                description = "Неудовлетворительно";
            }

            Console.WriteLine($"\nБалл: {score}");
            Console.WriteLine($"Оценка: {grade} - {description}");
        }
    }
}
