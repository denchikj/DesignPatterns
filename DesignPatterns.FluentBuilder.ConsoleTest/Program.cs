using DesignPatterns.FluentBuilder.Implementations;
using DesignPatterns.FluentBuilder.Interfaces;

namespace DesignPatterns.FluentBuilder.ConsoleTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            IFluentBuilder builder = new Implementations.FluentBuilder();
            
            IDirector director = new Director(builder);
            director.Construct();

            var car = builder.ReturnCar();
            Console.WriteLine(car);
        }
    }
}