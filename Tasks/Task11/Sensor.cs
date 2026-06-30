namespace C__TaskPractice.Tasks.Task11
{
    public class Sensor
    {
        public event EventHandler<TemperatureEventArgs> TemperatureExceeded;

        private decimal currentTemperature;
        private decimal threshold;

        public Sensor(decimal thresholdTemperature)
        {
            threshold = thresholdTemperature;
        }

        public decimal CurrentTemperature
        {
            get => currentTemperature;
            set
            {
                currentTemperature = value;
                if (currentTemperature > threshold)
                {
                    OnTemperatureExceeded(new TemperatureEventArgs(currentTemperature, threshold));
                }
            }
        }

        protected virtual void OnTemperatureExceeded(TemperatureEventArgs e)
        {
            TemperatureExceeded?.Invoke(this, e);
        }
    }
}
