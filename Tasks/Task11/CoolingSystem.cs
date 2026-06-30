namespace C__TaskPractice.Tasks.Task11
{
    public class CoolingSystem
    {
        public void Subscribe(Sensor sensor)
        {
            sensor.TemperatureExceeded += OnTemperatureExceeded;
        }

        public void Unsubscribe(Sensor sensor)
        {
            sensor.TemperatureExceeded -= OnTemperatureExceeded;
        }

        private void OnTemperatureExceeded(object sender, TemperatureEventArgs e)
        {
            Console.WriteLine($"ВНИМАНИЕ! Температура {e.CurrentTemperature} превысила порог {e.Threshold}");
            Console.WriteLine("Запуск системы охлаждения");
            Console.WriteLine("Охлаждение активировано\n");
        }
    }
}
