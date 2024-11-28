using MathShapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathShapes.Implementations
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Сторона треугольника.
        /// </summary>
        private double _a = 1, _b = 1, _c = 1;

        /// <summary>
        /// Конструктор треугольника, через длины его сторон.
        /// </summary>
        /// <exception cref="ArgumentException">Ошибка в случае невозможности существования треугольника с такими сторонами.</exception>
        public static Triangle FromSides(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();
            triangle.SetParamsSides(sideA, sideB, sideC);

            return triangle;
        }

        /// <summary>
        /// Задать описание треугольника, через длины его сторон.
        /// </summary>
        /// <exception cref="ArgumentException">Ошибка в случае невозможности существования треугольника с такими сторонами.</exception>
        public void SetParamsSides(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны треугольника не могут быть меньше или равны 0");
            }

            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > _a))
            {
                throw new ArgumentException("Сумма двух сторон треугольника всегда должна быть больше третьей");
            }

            _a = sideA; _b = sideB; _c = sideC;
        }

        /// <summary>
        /// Получить стороны треугольника
        /// </summary>
        /// <returns></returns>
        public double[] GetSides()
        {
            return [_a, _b, _c];
        }

        /// <inheritdoc/>
        public double GetSquare()
        {
            // Формула герона
            var p = GetPerimeter()/2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        /// <inheritdoc/>
        public double GetPerimeter()
        {
            return _a + _b + _c;
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            var sides = GetSides();
            Array.Sort(sides);

            // a^2 + b^2 == c^2
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var sides = GetSides();
            return $"треугольник(a={sides[0]}, b={sides[1]}, c={sides[2]})";
        }
    }
}
