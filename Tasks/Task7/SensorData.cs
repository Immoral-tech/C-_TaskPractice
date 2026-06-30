namespace C__TaskPractice.Tasks.Task7
{
    public class SensorData
    {
        public int SensorId { get; set; } = 0;
        public DateTime Timestamp { get; set; } = DateTime.Now;

        private double _temperature;
        public double Temperature
        {
            get => _temperature;
            set
            {
                if (value < -50 || value > 50)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(value),
                        "Температура должна быть в диапазоне от -50 до +50 градусов"
                    );
                }
                _temperature = value;
            }
        }

        public double Humidity { get; set; } = 50.0;
        public string Location { get; set; } = "Unknown";

        public SensorData()
        {
            SensorId = new Random().Next(1000, 9999);
            Temperature = 0;
        }

        public SensorData(double temperature, double humidity, string location)
        {
            SensorId = new Random().Next(1000, 9999);
            Timestamp = DateTime.Now;
            Temperature = temperature;
            Humidity = humidity;
            Location = location;
        }

        public SensorData(double temperature) : this(temperature, 50.0, "Default")
        {
        }

        public override string ToString()
        {
            return $"Сенсор #{SensorId} | " +
                   $"Температура: {Temperature:F1}°C | " +
                   $"Влажность: {Humidity:F0}% | " +
                   $"Местоположение: {Location} | " +
                   $"Время: {Timestamp:HH:mm:ss}";
        }
    }
}
