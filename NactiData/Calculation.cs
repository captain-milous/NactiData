using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NactiData
{
    /// <summary>
    /// Třída poskytuje základní matematické operace.
    /// </summary>
    public static class Calculation
    {
        /// <summary>
        /// Sečte dvě čísla.
        /// </summary>
        /// <param name="a">První číslo.</param>
        /// <param name="b">Druhé číslo.</param>
        /// <returns>Součet dvou čísel.</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Sečte tři čísla.
        /// </summary>
        /// <param name="a">První číslo.</param>
        /// <param name="b">Druhé číslo.</param>
        /// <param name="c">Třetí číslo.</param>
        /// <returns>Součet tří čísel.</returns>
        public static double Add(double a, double b, double c)
        {
            return Add(a, b) + c;
        }

        /// <summary>
        /// Vynásobí tři čísla.
        /// </summary>
        /// <param name="a">První číslo.</param>
        /// <param name="b">Druhé číslo.</param>
        /// <param name="c">Třetí číslo.</param>
        /// <returns>Výsledek násobení tří čísel.</returns>
        public static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

        /// <summary>
        /// Sečte dvě čísla a výsledek vydělí třetím číslem.
        /// </summary>
        /// <param name="a">První číslo.</param>
        /// <param name="b">Druhé číslo.</param>
        /// <param name="c">Číslo, kterým se dělí součet.</param>
        /// <returns>Výsledek dělení součtu dvou čísel třetím číslem.</returns>
        /// <exception cref="DivideByZeroException">Vyvolá se při pokusu o dělení nulou.</exception>
        public static double AddDivide(double a, double b, double c)
        {
            if (c == 0)
            {
                throw new DivideByZeroException("Nelze dělit nulou!");
            }
            else
            {
                return Add(a, b) / c;
            }
        }
    }

}
