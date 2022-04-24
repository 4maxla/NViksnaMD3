namespace ConsoleAppObjectsAndClasses
{
    public class Car
    {
        public string Brand { get; set; }
        public string PlateNumber { get; set; }
        public double Speed { get; set; }

        public void StartDrive()
        {
            Console.WriteLine($"{Brand} {PlateNumber} started to drive. Its speed is {Speed} km per hour.");
        }
        public double IncreaseSpeed()
        {
            Speed += 30;
            Console.WriteLine($"{Brand} {PlateNumber} increased its speed to {Speed} km per hour");
            return Speed;
        }

        public double DecreaseSpeed()
        {
            Speed -= 30;
            Console.WriteLine($"{Brand} {PlateNumber} decreased its speed to {Speed} km per hour");
            return Speed;
        }

        public double StopDrive()
        {
            Speed = 0;
            Console.WriteLine($"{Brand} {PlateNumber} stopped driving. Its speed is {Speed} km per hour.");
            return Speed;
        }

        public void Horn()
        {
            Console.WriteLine("Beep Beep");
        }
    }
}
