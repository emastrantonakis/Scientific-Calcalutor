using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastrantonakis_emmanouil_2
{
    class Calculations
    {
 
        public double Calculator(double a, double b, string calcOp)
        {
            switch (calcOp)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Can't divide by zero. Result set to 1");
                        return 1;
                    }
                    else
                    {
                        return a / b;
                    }
                case "%":
                    if (b == 0)
                    {
                        Console.WriteLine("Can't divide by zero to calculate the remainder." +
                            " Result set to 1");
                        return 1;
                    }
                    else
                    {
                        return a % b;
                    }
                case "Sq":
                case "sQ":
                case "sq":
                case "SQ":
                    return Math.Sqrt(a+b);
                default:
                    Console.WriteLine("Invalid operator");
                    return 1;
            }    
        }

        public int GCD(double result1, double result2)
        {
            if (result1 == 0 || result2 == 0)
            {
                Console.WriteLine("Can't calculate GDC. At least one of the numbers is 0.");
                return 0;
            }
            else if (result1 != Convert.ToInt32(result1) || result2 != Convert.ToInt32(result2))
            {
                Console.WriteLine("Can't calculate GDC. Both numbers must be integers.");
                return 0;
            }
            else
            {
                int min = Math.Min(Convert.ToInt32(result1), Convert.ToInt32(result2));
                for (int i = min; i >= 1; i--)
                {
                    if (result1 % i == 0 & result2 % i == 0)
                        return i;
                }
                return 1;
            }
 
        }

        public bool isPrimeNumber(double number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number != Convert.ToInt32(number))
            {
                return false;
            }
            for (int i = 2; i <= number-1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;    
        }

    }
}
