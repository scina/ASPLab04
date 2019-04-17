using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLab04
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.WriteLine();
           
            List<Product> products = new List<Product>()
            {
                new ForeignProduct("Ball01", 2, 100, "Sport", 10),
                new ForeignProduct("Ball02", 2, 200, "Sport", 10),
                new Product("Ball03", 2, 100, "Sport"),
                new Product("Ball04", 2, 200, "Sport")
            };
            

            foreach(Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.ReadKey();
            Console.WriteLine();

            QuadraticEquation.ShowResults(-2, 3, -1);

            Console.ReadKey();
            Console.WriteLine();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
