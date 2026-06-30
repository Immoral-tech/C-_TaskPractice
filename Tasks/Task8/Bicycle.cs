namespace C__TaskPractice.Tasks.Task8
{
    public class Bicycle : Vehicle
    {
        public int Gears { get; set; }
        public bool HasBell { get; set; }

        public Bicycle(string name, string color, int gears, bool hasBell)
            : base(name, color)
        {
            Gears = gears;
            HasBell = hasBell;
        }

        public override void Move()
        {
            Speed = 25;
            Console.WriteLine($"Велосипед {Name} разгоняется до {Speed} км/ч " +
                              $"(Передач: {Gears}, Звонок: {(HasBell ? "есть" : "нет")})");
        }

        public override void Stop()
        {
            Speed = 0;
            Console.WriteLine($"Велосипед {Name} остановился с помощью педалей.");
        }

        public void RingBell()
        {
            if (HasBell)
            {
                Console.WriteLine("Дзинь!");
            }
        }
    }
}
