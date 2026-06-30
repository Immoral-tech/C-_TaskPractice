namespace C__TaskPractice.Tasks.Task11
{
    public class TemperatureEventArgs : EventArgs
    {
        public decimal CurrentTemperature { get; }
        public decimal Threshold { get; }

        public TemperatureEventArgs(decimal currentTemp, decimal thresholdTemp)
        {
            CurrentTemperature = currentTemp;
            Threshold = thresholdTemp;
        }
    }
}
