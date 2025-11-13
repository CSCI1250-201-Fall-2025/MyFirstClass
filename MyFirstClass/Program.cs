namespace MyFirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.brand = "Chevy";
            myCar.name = "Silverado";
            myCar.PushButtonIgnition();
            Console.WriteLine(myCar.on);

            Console.WriteLine(myCar.PrintSymbol());

            Car yourCar = new Car();
            yourCar.brand = "Nissan";
            yourCar.name = "Altima";

            Console.WriteLine(yourCar.PrintSymbol());

            Car someoneElsesCar = new Car();
            yourCar.brand = "Honda";
            yourCar.name = "Civic";

            Console.WriteLine(someoneElsesCar.PrintSymbol());




            Circle circle1 = new Circle();

            circle1.radius = 10;

            Console.WriteLine(circle1.Circumfrence());


            Circle circle2 = new Circle();

            circle1.radius = 100;

            Console.WriteLine(circle1.Circumfrence());

            Console.WriteLine(Circle.PI);







        }

        static void ClearScreen()
        {
            Console.Clear();
        }
    }
}
