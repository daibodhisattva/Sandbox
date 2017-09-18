using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     class Calculator
    {
        // Integer
        public int calc(int x, int y, string op)
        {
            switch (op)
            {
                case "+":
                    return x + y;
                    break;
                case "-":
                    return x - y;
                    break;
                case "*":
                    return x * y;
                    break;
                case "/":
                    return x / y;
                    break;
                default:
                    throw new Exception("Invalid operation: Available operations are +, -, *, /");
            }
        }

        // Float

        public float calcfloat(float x, float y, string op)
        {
            switch (op)
            {
                case "+":
                    return x + y;
                    break;
                case "-":
                    return x - y;
                    break;
                case "*":
                    return x * y;
                    break;
                case "/":
                    if (y == 0)
                    {
                        throw new Exception("Cannot divide by 0!");
                    }
                    return x / y;
                    break;
                default:
                    throw new Exception("Invalid operation: Available operations are +, -, *, /");

            }
        }
    }
}
