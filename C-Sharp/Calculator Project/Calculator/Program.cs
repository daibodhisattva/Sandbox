using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Hello! Welcome to the Calculator App.\n Enter two numbers (integers or floats) and an operation (+, -, *, /).\n Enter the first number:\n");
            string inputX = Console.In.ReadLine();

            Console.WriteLine("Enter the second number: \n");
            string inputY = Console.In.ReadLine();

            Console.WriteLine("Enter the operation to be performed: \n");
            string operation = Console.In.ReadLine();

            int intX, intY;
            float fX, fY;
            object answer = null;

            try
            {
                if (Int32.TryParse(inputX, out intX) && Int32.TryParse(inputY, out intY))
                {
                    answer = calculator.calc(intX, intY, operation);     
                }
                else if (float.TryParse(inputX, out fX) && float.TryParse(inputY, out fY))
                {
                    answer = calculator.calcfloat(fX, fY, operation);      
                }
                else
                {
                    throw new Exception("Please enter numbers only!");
                }

                Console.WriteLine("Answer: " + answer);
                Console.WriteLine("Press any key to exit.");
                Console.In.ReadLine();
                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Press any key to exit.");
                Console.In.ReadLine();
            }
        }
    }

}
