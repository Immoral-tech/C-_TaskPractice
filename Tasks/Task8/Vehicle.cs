namespace C__TaskPractice.Tasks.Task8
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Speed { get; protected set; }

        protected Vehicle(string name, string color)
        {
            Name = name;
            Color = color;
            Speed = 0;
        }

        public abstract void Move();

        public virtual void Stop()
        {
            Speed = 0;
            Console.WriteLine($"{Name} остановился.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Транспорт: {Name}, Цвет: {Color}, Скорость: {Speed} км/ч");
        }
    }
}
