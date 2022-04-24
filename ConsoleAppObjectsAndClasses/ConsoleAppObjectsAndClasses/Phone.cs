namespace ConsoleAppObjectsAndClasses
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Size { get; set; }

        public void Call()
        {
            Console.WriteLine($"{Brand} {Model} is calling");
        }
        public void SendSMS()
        {
            Console.WriteLine($"{Brand} {Model} sent an SMS");
        }
    }
}