using System;

namespace Lab2
{
    internal class Program
    {
        static void PrintFigure(Figure f)
        {
            Console.WriteLine($"{f.Name}");
            Console.WriteLine($"S = {f.GetArea()}\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2\n");

            Rectangle rectangle = new Rectangle() { Name = "Прямоугольник:", Height = 2, Width = 5};
            Circle circle = new Circle() { Name = "Круг:", Raduis = 5 };
            Square square = new Square() { Name = "Квадрат:", Side = 2 };
            Triangle triangle = new Triangle() { Name = "Треугольник:", Height = 7, Bottom = 3 };
            Trapeze trapeze = new Trapeze() { Name = "Трапеция:", Bottom = 8, Top = 10 };
            Rhomb rhomb = new Rhomb() { Name = "Ромб:", Side = 3, Height = 8 };
            Parallelogram parallelogram = new Parallelogram() { Name = "Параллелограмм:", Height = 11, Side = 4 };
            Pentagon pentagon = new Pentagon() { Name = "Правильный пятиугольник:", Side = 3 };
            Decagon decagon = new Decagon() { Name = "Правильный десятиугольник:", Side = 7 };

            PrintFigure(rectangle);
            PrintFigure(circle);
            PrintFigure(square);
            PrintFigure(triangle);
            PrintFigure(trapeze);
            PrintFigure(rhomb);
            PrintFigure(parallelogram);
            PrintFigure(pentagon);
            PrintFigure(decagon);
        }
    }
}
