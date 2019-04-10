using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigure
{
    abstract class FigureAbst
    {
        public double width;
        public double height;
        public double perimeterRectangle;
        public double sqareRectangle;

        public abstract double Square();
        public double Perimeter()
        {
            perimeterRectangle = 2 * (height + width);
            return perimeterRectangle;
        }
    }
}
