using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point point1 = new point(), point2 = new point();
            Console.WriteLine($"Введите координаты первой точки.");
            point1.vvod();
            Console.WriteLine($"Введите координаты второй точки.");
            point2.vvod();
            Console.WriteLine($"Расстояние между точками = {point1.distance(point2)}");
            line line1 = new line();
            Console.WriteLine($"Введите координаты первой и второй точки линии.");
            line1.vvod();
            line1.vivod();
            angle angle1 = new angle();
            Console.WriteLine($"Введите координаты точкек: на первой стороне угла, вершины, на второй стороне угла.");
            angle1.vvod();
            angle1.vivod();
            Console.WriteLine($"Значение угла = {angle1.value()} градусов.");
            triangle tri1 = new triangle();
            Console.WriteLine($"Введите координаты точек треугольника.");
            tri1.vvod();
            tri1.vivod();
            Console.WriteLine($"Площадь треугольника = {tri1.square()}, периметр треугольника = {tri1.per()}");
            circle circle1 = new circle();
            Console.WriteLine($"Введите координаты цента круга и его радиус.");
            circle1.vvod();
            circle1.vivod();
            Console.WriteLine($"Площадь круга = {circle1.square()}, периметр круга = {circle1.per()}");
            segments sm1 = new segments();
            Console.WriteLine($"Введите координаты цента круга и его радиус.");
            sm1.vvod();
            sm1.totalvivod();
            Console.WriteLine($"Общая длина = {sm1.totallength()}");
            Console.ReadLine();
        }
    }
}