using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation equation;
            equation.k = 0;
            equation.b = 0;
            equation.Root();
            Console.ReadKey();
        }

    }
    struct Equation
    {

        public double k;


        public double b;



        public void Root()
        {
            double x = 0;

            x = (0 - b) / k;

            if (Double.IsInfinity(x)||Double.IsNaN(x))
            {

                Console.Write("Деление на ноль!");
            }
            else
            {
                double result = x;
                Console.WriteLine("Решение уравнения: {0:f2}", result);

            }










        }
    }
}


