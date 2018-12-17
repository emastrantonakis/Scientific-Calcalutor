using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastrantonakis_emmanouil_2
{
    class QnA
    {
        public double number1;
        public double number2;
        public string calcOperator;

        public  QnA()
        {
            Console.Write("Please insert the First Number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("OK.Please insert the Second Number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insert the calculation operator:\n\"+\" , \"-\" , \"*\" , " +
                "\"/\", \"%\" or \"Sq\" (for Square Root of the two numbers combined): ");
            string calcOperator = (Console.ReadLine());
            while (calcOperator != "+" && calcOperator != "-" && calcOperator != "*"
                && calcOperator != "/" && calcOperator != "%" && calcOperator != "Sq"
                && calcOperator != "sq" && calcOperator != "SQ")
            {
                Console.Write("Invalid input please try again: ");
                calcOperator = (Console.ReadLine());
            }
            this.calcOperator = calcOperator;
        }
    }
}
