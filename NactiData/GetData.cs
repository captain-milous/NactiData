using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NactiData
{
    /// <summary>
    /// Třída poskytuje metodu pro získání číselného vstupu od uživatele prostřednictvím konzole.
    /// </summary>
    public static class GetData
    {
        /// <summary>
        /// Načte číselný vstup od uživatele z konzole. Opakuje dotaz, dokud uživatel nezadá platné číslo.
        /// </summary>
        /// <returns>Číslo zadané uživatelem.</returns>
        public static double GetNumFromConsole()
        {
            while (true)
            {
                double num = 0;
                string input = Console.ReadLine();
                if (double.TryParse(input, out num))
                {
                    return num;
                }
                else
                {
                    Console.Write("Toto není číslo!\nZadejte číslo znovu: ");
                }
            }
        }
    }
}
