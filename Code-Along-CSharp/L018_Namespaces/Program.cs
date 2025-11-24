
using MyNamespace;
//using MyNamespace.MyOtherNamespace;

MyNamespace.MyOtherNamespace.Car myCar;

MyNamespace.Boat myBoat;

Car car = new Car();
MyNamespace.MyOtherNamespace.Car.Engine = string.Empty;

Console.WriteLine();

namespace MyNamespace
{
    class Car
    {
        public static string Model;
    }

}

namespace MyNamespace
{
    class Boat
    {

    }

}

namespace MyNamespace.MyOtherNamespace
{
    class Car
    {
        public static string Engine;
    }

}
