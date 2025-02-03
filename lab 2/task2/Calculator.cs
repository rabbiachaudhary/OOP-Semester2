using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Calculator
    {
        public double n1;
        public double n2;
        public double Add()
        {
            return (n1 + n2);
        }
        public double Substract()
        {
            return (n1 - n2);
        }
        public double Multiply()
        {
            return (n1 *n2);
        }
        public double Divide()
        {
            return (n1 / n2);
        }
        public Calculator(double N1, double N2)
        {
            n1 = N1;
            n2 = N2;
        }
    }
}
