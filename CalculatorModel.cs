using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {
            
        }

        public object Calculate(int operand1, int operand2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return Sum(operand1,operand2);
                case '-':
                    return Substract(operand1, operand2);
                case '/':
                    return Divide(operand1, operand2);
                case '*':
                    return Multiply(operand1, operand2);
                case '^':
                    return Power(operand1, operand2);
                default:
                    return 0;
            }
        }

        public int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int Substract(int a, int b)
        {
            int result = a - b;
            return result;
        }

        public int Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }

        public int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public int Power(int a, int b)
        {
            int result = a;

            for (int i=1; i<b; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}
