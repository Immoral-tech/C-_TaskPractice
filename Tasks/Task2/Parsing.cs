namespace C__TaskPractice.Tasks.Task2
{
    public class Parsing
    {
        public static double CalculateTime()
        {
            Console.Write("Введите растояние в км: ");
            double distance;
            bool isValid;

            // Запрос расстояния с проверкой
            do
            {
                Console.Write("Введите расстояние в км: ");
                string? input = Console.ReadLine();
                isValid = double.TryParse(input, out distance);

                if (!isValid)
                {
                    Console.WriteLine("Ошибка! Введите корректное число");
                }
            } 
            while (!isValid);

            // Запрос скорости с проверкой
            double speed;
            do
            {
                Console.Write("Введите скорость в км/ч: ");
                string? input = Console.ReadLine();
                isValid = double.TryParse(input, out speed);

                if (!isValid)
                {
                    Console.WriteLine("Ошибка! Введите корректное число");
                }
            } while (!isValid);
            return distance / speed;
        }
    }
}
