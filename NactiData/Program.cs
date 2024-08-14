using static NactiData.GetData;
using static NactiData.Calculation;

namespace NactiData
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte vstupní parametry: ");
            Console.Write("Číslo 1: ");
            double a = GetNumFromConsole();
            Console.Write("Číslo 2: ");
            double b = GetNumFromConsole();
            Console.Write("Číslo 3: ");
            double c = GetNumFromConsole();

            Console.WriteLine();
            double result = Add(a, b, c);
            Console.WriteLine(a + " + " + b + " + " + c + " = " + result);
            result = Multiply(a, b, c);
            Console.WriteLine(a + " * " + b + " * " + c + " = " + result);            
            try
            {
                result = AddDivide(a, b, c);
                Console.WriteLine("(" + a + " + " + b + ") / " + c + " = " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("(" + a + " + " + b + ") / " + c + " = " + ex.Message);
            }
            
        }
    }
}
