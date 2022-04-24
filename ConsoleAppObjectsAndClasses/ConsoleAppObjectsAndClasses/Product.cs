namespace ConsoleAppObjectsAndClasses
{
    public class Product
    {
        public Product(double length, double width, double height, double weight)
        {
            Length = 15; // Nemainīgs
            Width = 20; // Nemainīgs
            Height = 10.5; // Nemainīgs
            Weight = weight; // Mainīgs
        }
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }
        public double Weight { get; set; }




    }
}
