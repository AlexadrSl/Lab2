using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №2");
            Console.WriteLine("Выполнил - Саламахин Александр");

            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник", Width = 15.2, Height = 13.7

            };
            
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());

            Circle b = new Circle()
            {
                Name = "Круг",
                Raduis = 2
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.GetArea());

            Square c = new Square()
            {
                Name = "Квадрат",
                Side = 2
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", c.Name);
            Console.WriteLine("Площадь фигуры: {0}", c.GetArea());

            Rhomb d = new Rhomb()
            {
                Name = "Ромб",
                Side = 2, Height = 4
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", d.Name);
            Console.WriteLine("Площадь фигуры: {0}", d.GetArea());

            Decagon r = new Decagon()
            {
                Name = "Десятиугльник",
                Side = 5
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", r.Name);
            Console.WriteLine("Площадь фигуры: {0}", r.GetArea());

            Pentagon v = new Pentagon()
            {
                Name = "Пятиугольник",
                Side = 7
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", v.Name);
            Console.WriteLine("Площадь фигуры: {0}", v.GetArea());

            Trapeze j = new Trapeze()
            {
                Name = "Трапеция",
                Top = 2, Bottom = 4
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", j.Name);
            Console.WriteLine("Площадь фигуры: {0}", j.GetArea());

            Triangle p = new Triangle()
            {
                Name = "Триугольник",
                Height = 2, Bottom=  7
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", p.Name);
            Console.WriteLine("Площадь фигуры: {0}", p.GetArea());

            Parallelogram q = new Parallelogram()
            {
                Name = "Параллелограмм",
                Side = 4, Height = 8
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", q.Name);
            Console.WriteLine("Площадь фигуры: {0}", q.GetArea());
        }
    }
}
