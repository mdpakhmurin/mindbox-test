using MathShapes.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace MathShapes.Implementations
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        private double _radius = 1;

        /// <summary>
        /// Создание круга, через радиус.
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentException">Ошибка в случае невозможности существования круга с такими радиусом.</exception>
        public static Circle FromRadius(double radius) {
            var circle = new Circle();
            circle.SetParamsRadius(radius);

            return circle;
        }

        /// <summary>
        /// Задать описание круга, через радиус.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        /// <exception cref="ArgumentException">Ошибка в случае невозможности существования круга с такими радиусом.</exception>
        public void SetParamsRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга не может быть меньше или равен 0");
            }
            _radius = radius;
        }

        /// <inheritdoc/>
        public double GetSquare()
        {
            return Math.PI * _radius * _radius;
        }

        /// <inheritdoc/>
        public double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        /// <summary>
        /// Получить радиус окружности
        /// </summary>
        /// <returns></returns>
        public double GetRadius()
        {
            return _radius;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"круг(r={GetRadius()})";
        }
    }
}