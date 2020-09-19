using System;

namespace Usr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Reader reader = new Reader();

            double massOfPlanet = reader.ReadValue("Enter Mass Of Planet: ");
            double planetRadius = reader.ReadValue("Enter Planet Radius: ");
            double heightAboveSurface = reader.ReadValue("Enter Height Above Surface: ");

            Console.Write("Speed = ");
            Console.WriteLine(calculator.Calculate(massOfPlanet, planetRadius, heightAboveSurface));
        }
    }
}