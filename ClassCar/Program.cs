using carProject;
internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car { Brand = "Volvo", Speed = 0 };
        myCar.StartEngine();
        myCar.StartAndDrive();
        Car.CarInfo();
        Console.ReadLine();
    }
}