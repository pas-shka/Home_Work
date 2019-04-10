using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigure
{
    class Circle : IFigures
    {
        double radius;
        double squareCircle;
        double perimeterCircle;

        public Circle(int radius)
        {
            this.radius = radius;

        }
        public double Perimeter()
        {
            perimeterCircle = 2 * Math.PI * radius;
            return perimeterCircle;
        }

        public double Square()
        {
            squareCircle = radius * radius * Math.PI;
            return squareCircle;
        }
    }
}
