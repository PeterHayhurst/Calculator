using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcMultiply : Calc
    {
     

        public CalcMultiply(double firstNumber, double secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public override double CalculateExpression()
        {
            return this.firstNumber * this.secondNumber;
        }
    }
}
