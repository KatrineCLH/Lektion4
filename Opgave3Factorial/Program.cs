using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.ReadLine();
        }

        static int Factorial(int n)
        {
            if (n >= 0)
            {
                if (n == 0)
                {
                    return 1;
                }
                else
                {
                    return n * Factorial(n - 1);
                }
            }
            else return -1;
        }
    }
}
