using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathShapes.Interfaces
{
    /// <summary>
    /// Возможность вычисления площади.
    /// </summary>
    public interface ISquareable
    {
        /// <summary>
        /// Получение площади.
        /// </summary>
        /// <returns>Площадь.</returns>
        double GetSquare();
    }
}
