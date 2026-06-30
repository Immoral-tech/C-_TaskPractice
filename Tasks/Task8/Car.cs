namespace C__TaskPractice.Tasks.Task8
{
    public class Car : Vehicle
    {
        public int EnginePower { get; set; }
        public int DoorsCount { get; set; }

        public Car(string name, string color, int enginePower, int doors)
            : base(name, color)
        {
            EnginePower = enginePower;
            DoorsCount = doors;
        }

        public override void Move()
        {
            Speed = 120;
            Console.WriteLine($"Автомобиль {Name} разгоняется до {Speed} км/ч " +
                              $"(Двигатель: {EnginePower} л.с., Дверей: {DoorsCount})");
        }

        public override void Stop()
        {
            base.Stop();
            Console.WriteLine($"Автомобиль {Name} замедляется с помощью тормозов.");
        }
    }
}
