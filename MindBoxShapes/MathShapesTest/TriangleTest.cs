using MathShapes.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathShapesTest
{
    /// <summary>
    /// Проверка работы с классом треугольника.
    /// </summary>
    [TestClass]
    public sealed class TriangleTest
    {
        /// <summary>
        /// Проверка возможности создания объекта.
        /// </summary>
        [TestMethod]
        public void TestCreation()
        {
            try
            {
                // Проверка создания без ошибок корректных треугольников
                Triangle.FromSides(1,1,1);
                Triangle.FromSides(3,5,4);
            }
            catch (ArgumentException)
            {
                Assert.Fail("Создание треугольник с корректными параметрами завершилось с ошибкой");
            }

            // Проверка создания несуществующий треугольников (с ошибкой)
            Assert.ThrowsException<ArgumentException>(() => Triangle.FromSides(1,2,3), "Создан несуществующий треугольник");
            Assert.ThrowsException<ArgumentException>(() => Triangle.FromSides(3,8,3), "Создан несуществующий треугольник");
        }

        /// <summary>
        /// Проверка корректного сохранения длин
        /// </summary>
        [TestMethod]
        public void TestSetSides()
        {
            Triangle triangle;

            // Проверка установки радиуса при создании.
            triangle = Triangle.FromSides(3, 4, 5);
            CollectionAssert.AreEqual(new double[3] { 3, 4, 5 }, triangle.GetSides(), "Сохраненные значения длин сторон треугольника не соответствуют полученному");

            //// Проверка установки радиуса при изменении параметров.
            triangle = Triangle.FromSides(5, 4, 6);
            CollectionAssert.AreEqual(new double[3] { 5, 4, 6 }, triangle.GetSides(), "Сохраненные значения длин сторон треугольника не соответствуют полученному");
        }

        /// <summary>
        /// Проверка вычисления площади
        /// </summary>
        [TestMethod]
        public void TestGetSquare()
        {
            Triangle triangle;

            triangle = Triangle.FromSides(3, 4, 5);
            Assert.AreEqual(6, triangle.GetSquare(), "Площадь вычислена неверно");

            triangle = Triangle.FromSides(5, 4, 6);
            Assert.AreEqual(9.92157, Math.Round(triangle.GetSquare(),5), "Площадь вычислена неверно");
        }

        /// <summary>
        /// Проверка вычисления периметра
        /// </summary>
        [TestMethod]
        public void TestGetPerimeter()
        {
            Triangle triangle;

            triangle = Triangle.FromSides(3, 4, 5);
            Assert.AreEqual(12, triangle.GetPerimeter(), "Периметр вычислен неверно");

            triangle = Triangle.FromSides(5, 4, 6);
            Assert.AreEqual(15, triangle.GetPerimeter(), "Периметр вычислен неверно");
        }
    }
}
