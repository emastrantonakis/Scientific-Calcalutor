using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastrantonakis_emmanouil_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This is an awesome calculator.");

            QnA answers1 = new QnA();
            Calculations calc = new Calculations();
            double firstResult = calc.Calculator(answers1.number1, answers1.number2, answers1.calcOperator);
            Console.WriteLine($"The first result is {firstResult}");

            Console.WriteLine("Ok lets do this again");

            QnA answers2 = new QnA();
            double secondResult = calc.Calculator(answers2.number1, answers2.number2, answers2.calcOperator);
            Console.WriteLine($"The second result is {secondResult}");

            int thirdResult = calc.GCD(firstResult, secondResult);
            if (thirdResult != 0)
            {
                Console.WriteLine($"The greatest common divisor of the two results is {thirdResult}");
            }

            if (calc.isPrimeNumber(secondResult))
            {
                Console.WriteLine($"The number {secondResult} is a prime number");
            }
            else
            {
                Console.WriteLine($"The number {secondResult} is not a prime number");
            }

            Fibonacci fibo = new Fibonacci();
            long secondResultFibonacci = Convert.ToInt64(secondResult);
            long fiboOf2ndResult = fibo.getFibonacci(secondResultFibonacci);
            Console.WriteLine($"The {secondResultFibonacci}th Fibonacci number is {fiboOf2ndResult}");

            if (fibo.isFibonacci(secondResult))
            {
                Console.WriteLine($"The number {secondResult} (2nd result) is a fibonacci number");
            }
            else
            {
                Console.WriteLine($"The number {secondResult} (2nd result) isn't a fibonacci number");
            }

            Console.ReadKey();

        }
    }
}
