using MathShapes.Implementations;
using MathShapes.Interfaces;

namespace MindBoxShapes
{
    public class Program
    {
        /// <summary>
        /// Легкость добавления других фигур
        /// </summary>
        private class SquareShape : IShape
        {
            public double A { get; set; }
            public double B { get; set; }

            public SquareShape(double a, double b)
            {
                A = a;
                B = b;
            }

            public double GetPerimeter() => (A + B) * 2;

            public double GetSquare() => A * B;

            public override string ToString() => $"квадрат(a={A}, b={B})";
        }

        static void Main(string[] args)
        {
            CalcSquares();
            Console.WriteLine();
            IsRightTriangleCheck();
        }

        /// <summary>
        /// Вычисление площади фигуры без знания типа фигуры в compile-time.
        /// </summary>
        private static void CalcSquares()
        {
            var shapes = new IShape[]
            {
                Circle.FromRadius(10),
                Triangle.FromSides(3,4,5),
                new SquareShape(2, 8),
                Circle.FromRadius(5),
                Triangle.FromSides(8,3,7)
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Площадь {shape}: {shape.GetSquare()}");
            }
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        private static void IsRightTriangleCheck()
        {
            var rightTriangle = Triangle.FromSides(3, 4, 5);
            var notRightTriangle = Triangle.FromSides(8, 3, 7);

            Console.WriteLine($"{rightTriangle} прямоугольный? - {rightTriangle.IsRightTriangle()}");
            Console.WriteLine($"{notRightTriangle} прямоугольный? - {notRightTriangle.IsRightTriangle()}");
        }
    }
}
