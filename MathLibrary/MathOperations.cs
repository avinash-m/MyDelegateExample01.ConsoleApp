using System;

namespace MathLibrary
{
    // Avinash
    public static class MathOperations
    {
        static MathOperations()
        {
            Console.WriteLine("--- In Static Class ---\n");
        }

        public static double Addition(double firstNumber, double secondNumber)
        {
            double sum = 0.0;
            if (firstNumber > 0 && secondNumber > 0)
            {
                sum = firstNumber + secondNumber;
                return sum;
                //Console.WriteLine($"Addition of numbers: { sum }");
            }
            else
            {
                return sum;
                //Console.WriteLine("Additon: Numbers should be greater than zero.");
            }
        }

        public static double Subtraction(double firstNumber, double secondNumber)
        {
            double result = 0.0;
            if (firstNumber > 0 && secondNumber > 0)
            {
                result = firstNumber - secondNumber;
                return result;
                //Console.WriteLine($"Addition of numbers: { sum }");
            }
            else
            {
                return result;
                //Console.WriteLine("Additon: Numbers should be greater than zero.");
            }
        }

        public static double Multiplication(double firstNumber, double secondNumber)
        {
            double Multiplier = firstNumber * secondNumber;
            return Multiplier;
            //Console.WriteLine("Multiplication of Numbers: {0}", Multiplier.ToString());
        }

        public static double Division(double firstNumber, double secondNumber)
        {
            double quotient = 0.0;
            if (secondNumber != 0)
            {
                quotient = firstNumber / secondNumber;
                return quotient;
            }
            return quotient;

        }

        public static double Remainder(double firstNumber, double secondNumber)
        {
            double remainder = 0.0;
            if (secondNumber != 0)
            {
                remainder = firstNumber % secondNumber;
                return remainder;
            }
            else
            {
                return remainder;
            }

        }
    }

    
    
}
