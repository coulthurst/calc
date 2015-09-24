using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Operation
    {
     
        public double? Subtract(double? num1 , double? num2)
        {
            double? total = num1 - num2;
            return total;
        }
        public double? Multiply(double? num1, double? num2)
        {
            double? total = num1 * num2;
            return total;
        }
        public double? Divide(double? num1, double? num2)
        {
            double? total = num1 / num2;
            return total;
        }
        public double? Add(double? num1, double? num2)
        {
            double? total = num1 + num2;
            return total;
        }
    }
}
