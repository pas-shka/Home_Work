using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigure
{
    class Rectangle : FigureAbst
    {
        public Rectangle(double width) : this(width , width) //квадрат
        {
            this.width = width;
        }
        public Rectangle(double width, double height) //прямоугольник
        {
            this.width = width;
            this.height = height;
        }

        public override double Square()
        {
            sqareRectangle = height * width;
            return sqareRectangle;
        }
    }
}
