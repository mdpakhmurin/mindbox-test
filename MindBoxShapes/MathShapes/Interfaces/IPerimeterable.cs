using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathShapes.Interfaces
{
    /// <summary>
    /// Возможность вычисления периметра.
    /// </summary>
    public interface IPerimeterable
    {
        /// <summary>
        /// Получение периметра.
        /// </summary>
        /// <returns>Периметр.</returns>
        double GetPerimeter();
    }
}
