using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    internal class point
    {
        private double x, y;
        public void vvod()
        {
            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Координата x введена неверно.");
            while (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Координата y введена неверно.");
        }
        public void vivod()
        {
            Console.Write($"x={x}, y={y}");
        }
        public double distance(point sdpoint)
        {
            return Math.Sqrt(Math.Pow(sdpoint.x - x, 2) + Math.Pow(sdpoint.y - y, 2));
        }
        public double getx()
        {
            return x;
        }
        public double gety()
        {
            return y;
        }
    }
}
