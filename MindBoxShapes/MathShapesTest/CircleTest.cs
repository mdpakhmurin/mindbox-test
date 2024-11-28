using MathShapes.Implementations;

namespace MathShapesTest
{
    /// <summary>
    /// Проверка работы с классом круга.
    /// </summary>
    [TestClass]
    public sealed class CircleTest
    {
        /// <summary>
        /// Проверка возможности создания объекта.
        /// </summary>
        [TestMethod]
        public void TestCreation()
        {
            try
            {
                // Проверка создания без ошибок корректных кругов
                Circle.FromRadius(99999.99999);
                Circle.FromRadius(2);
            }
            catch (ArgumentException)
            {
                Assert.Fail("Создание круга с корректными параметрами завершилось с ошибкой");
            }

            // Проверка создания несуществующий кругов (с ошибкой)
            Assert.ThrowsException<ArgumentException>(() => Circle.FromRadius(0), "Создан несуществующий круг");
            Assert.ThrowsException<ArgumentException>(() => Circle.FromRadius(-23), "Создан несуществующий круг");
        }

        /// <summary>
        /// Проверка корректного сохранения радиуса
        /// </summary>
        [TestMethod]
        public void TestSetRadius()
        {
            double radius;
            Circle circle;

            // Проверка установки радиуса при создании.
            radius = 99999.99999;
            circle = Circle.FromRadius(99999.99999);
            Assert.AreEqual(circle.GetRadius(), radius, "Сохраненное значение радиуса не соответствуют полученному");

            // Проверка установки радиуса при изменении параметров.
            radius = 1234.4321;
            circle.SetParamsRadius(radius);
            Assert.AreEqual(circle.GetRadius(), radius, "Сохраненное значение радиуса не соответствуют полученному");
        }

        /// <summary>
        /// Проверка вычисления площади
        /// </summary>
        [TestMethod]
        public void TestGetSquare()
        {
            var circle = Circle.FromRadius(2);
            Assert.AreEqual(12.56637, Math.Round(circle.GetSquare(), 5), "Площадь вычислена неверно");

            circle = Circle.FromRadius(99.99);
            Assert.AreEqual(78.53982, Math.Round(circle.GetSquare(), 5), Math.Round(99.99 * 99.99 * Math.PI, 5), "Площадь вычислена неверно");
        }

        /// <summary>
        /// Проверка вычисления периметра
        /// </summary>
        [TestMethod]
        public void TestGetPerimeter()
        {
            var circle = Circle.FromRadius(2);
            Assert.AreEqual(12.56637, Math.Round(circle.GetPerimeter(), 5), "Периметр вычислен неверно");

            circle = Circle.FromRadius(99.99);
            Assert.AreEqual(628.25570, Math.Round(circle.GetPerimeter(), 5), "Периметр вычислен неверно");
        }
    }
}
