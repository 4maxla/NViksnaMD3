// See https://aka.ms/new-console-template for more information

using ConsoleAppObjectsAndClasses;

Console.WriteLine();
Console.WriteLine(" // 1. Uzdevums // Telefons //");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("- Phone 1 -");
Console.WriteLine();

Phone phone1 = new Phone()
{
    Brand = "Samsung",
    Model = "S22 Ultra",
    Size = 6.43
};

phone1.Call();
phone1.SendSMS();

Console.WriteLine();
Console.WriteLine("- Phone 2 -");
Console.WriteLine();

Phone phone2 = new Phone()
{
    Brand = "Apple",
    Model = "iPhone 13 Pro",
    Size = 6.1
};

phone2.Call();
phone2.SendSMS();


Console.WriteLine();
Console.WriteLine(" // 2. Uzdevums // Mašīna //");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("- Car 1 -");
Console.WriteLine();

Car car1 = new Car()
{
    Brand = "Nissan Micra",
    PlateNumber = "HK-4320",
    Speed = 20
};

car1.StartDrive();
car1.IncreaseSpeed();
car1.DecreaseSpeed();
car1.Horn();
car1.StopDrive();

Console.WriteLine();
Console.WriteLine("- Car 2 -");
Console.WriteLine();

Car car2 = new Car()
{
    Brand = "BMW M5",
    PlateNumber = "LV-1337",
    Speed = 50
};

car2.StartDrive();
car2.IncreaseSpeed();
car2.DecreaseSpeed();
car2.Horn();
car2.StopDrive();


Console.WriteLine();
Console.WriteLine(" // 3. Uzdevums // Prece //");
Console.WriteLine();

Console.Write("Enter product's length: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Enter product's width: ");
double width = double.Parse(Console.ReadLine());

Console.Write("Enter product's height: ");
double height = double.Parse(Console.ReadLine());

Console.Write("Enter product's weight: ");
double weight = double.Parse(Console.ReadLine());


Product product1 = new Product(length, width, height, weight);


void GetDimmnesions()
{
    Console.WriteLine($"Product's length must be {product1.Length}");
    Console.WriteLine($"Product's width must be {product1.Width}");
    Console.WriteLine($"Product's height must be {product1.Height}");
    Console.WriteLine($"Product's weight is {product1.Weight}");
}

GetDimmnesions();

Console.WriteLine();
Console.WriteLine(" // 4. Uzdevums // Persona //");
Console.WriteLine();

Console.Write("Enter your Name: ");
string name = Console.ReadLine();


Console.Write("Enter your Surname: ");
string surname = Console.ReadLine();

Console.Write("Enter date of Birth in format DD/MM/YYYY: ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Console.Write("What is your hobby: ");
string hobby = Console.ReadLine();

Person person = new Person()
{
    Name = name,
    Surname = surname,
    BirthDate = birthDate,
    Hobby = hobby,
    IsMale = true
};

int yearsOld = person.GetAge();

Console.WriteLine($"Hello my name is {person.Name} {person.Surname}. I am {yearsOld} years old {person.IsMale} male and my hobby is {person.Hobby}.");