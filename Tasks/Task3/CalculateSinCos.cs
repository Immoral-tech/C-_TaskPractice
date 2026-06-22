namespace C__TaskPractice.Tasks.Task3
{
    public class CalculateSinCos
    {
        public static void CalculateRadians(double gradus)
        {
            double radians = gradus * Math.PI / 180;

            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);

            Console.WriteLine($"Синус угла {gradus} равен {sin}");
            Console.WriteLine($"Косинус угла {gradus} равен {cos}");
        }
    }
}
