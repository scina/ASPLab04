using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLab04
{
    static class QuadraticEquation
    {
        static double Delta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        static public List<double> GetResultList(double a, double b, double c)
        {
            List<double> results = new List<double>();
            double delta = Delta(a, b, c);
            if ( delta == 0)
            {
                results.Add(((-1)*b) / (2 * a));
            }
            else if (delta > 0)
            {
                results.Add((((-1) * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
                results.Add((((-1) * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
            }

            return results;
        }

        public static void ShowResults(double a, double b, double c)
        {
            List<double> results = GetResultList(a, b, c);
            if (results.Count == 0)
            {
                Console.WriteLine("No results for: " + a + "x(2) + " + b + "x + " + c);
            }
            else
            {
                Console.WriteLine("Results for: " + a + "x(2) + " + b + "x + " + c + ": ");
                foreach (double result in results)
                {
                    Console.WriteLine("Result: " + result);
                }
            }
        }
    }
}
