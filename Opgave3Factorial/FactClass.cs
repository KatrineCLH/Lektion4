using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ext
{
    
    
        public static class FactClass
        {
            public static int Factorial(this int n)
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
