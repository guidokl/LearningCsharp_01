namespace L02_StaticClassAndMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.StartEngine();
            Tools.PrintMessage($"This car has {car1.NumberOfWheels} wheels.");
            // Car.StartEngine(); -> This line would cause a compile-time error

            Tools.PrintMessage("Hello."); // Possible to call static method directly
            // Tools tool1 = new Tools(); -> This line would cause a compile-time error
            // because static classes cannot be instantiated
        }
    }

    class Car
    {
        public int NumberOfWheels = 4;
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
    }

    static class Tools
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
