using carProject;
internal class Program
{

    private static void Main(string[] args)
    {
        Car myCar = new Car { Brand = "Volvo", Speed = 0 };
        myCar.StartEngine();
        myCar.StartAndDrive();
        Car.CarInfo();


        int sum = SimpleMath.Add(5, 7);
        int product = SimpleMath.Multiply(3, 4);
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");

        SimpleMath mathObj = new SimpleMath();
        SimpleMath mathObj2 = new SimpleMath();

        int resultFromMath1 = SimpleMath.Add(5, 3); // 8

        int finalResult = SimpleMath.Multiply(resultFromMath1, 2); // 16
        Console.WriteLine(finalResult);

        mathObj.Subtract(10, 3); // ändrar LastResult
        mathObj.Divide(20, 4); // ändrar LastResult
        Console.WriteLine($"Senaste resultat lagrat i objektet: {mathObj.LastResult}");
        Console.ReadLine(); // Behövs för att hålla konsolen öppen

    }
}

