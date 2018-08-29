using System;
using MathLibrary;

namespace MyDelegateExample01.ConsoleApp
{
    public delegate double MathOpertion(double firstNumber, double secondNumber);
     
    class Program
    {
        //private static double Add(double firstNumber, double secondNumber)
        //{
        //    Console.WriteLine("Add method:");
        //    return (firstNumber + secondNumber);
        //}

        static void Main(string[] args)
        {
            MathOpertion mo = new MathOpertion(Add);

        }
    }
}
