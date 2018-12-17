using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastrantonakis_emmanouil_2
{
    class Fibonacci
    {
        public long f1 = 1;
        public long f2 = 1;

        public long getFibonacci (long n)
        {
            if (n > 92)
            {
                Console.WriteLine("Fibonacci numbers over 92 can't be calcualated correctly " +
                    "with the long data type. Result set to 0");
                return 0;
            }
            else
            {
                long fiboresult = 1;
                for (long i = 2; i < n; i++)
                {
                    fiboresult = f1 + f2;
                    f1 = f2;
                    f2 = fiboresult;
                }
                return fiboresult;
            }
        }
        public bool isPerfectSquare(long x)
        {
            long y = Convert.ToInt64(Math.Sqrt(x));
            return (y * y == x);

        }

        public bool isFibonacci(double x)
        {
            long y = Convert.ToInt64(x);
            if (y != x)
            {
                return false;
            }
            return (isPerfectSquare(5 * y * y + 4) || isPerfectSquare(5 * y * y - 4));
        }

    }
}
