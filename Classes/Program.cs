using System.Security.AccessControl;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Year = 2023;
            car1.Make = "Audi";
            car1.Model = "Q5";
            Console.WriteLine($"{car1.Year} {car1.Make} { car1.Model}");  

        }
    }
}
