using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle A = new Circle(10);
            Console.WriteLine(A.Square());

            Rectangle B = new Rectangle(10,5);
            Console.WriteLine(B.Perimeter());

            Console.ReadKey();
        }
    }
}
