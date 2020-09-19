using System;

namespace Usr1
{
    public class Calculator
    {
        const double G  = 6.67E-11;

        public double Calculate(double massOfPlanet, double radiusOfPlanet, double heightAboveSurface)
        {
            double sumHeight = radiusOfPlanet + heightAboveSurface;
            double speed = Math.Sqrt(heightAboveSurface / sumHeight);

            return speed;
        }
    }
}