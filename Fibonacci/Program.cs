using System;
/*
    Main Class
    This Class is designed to run the main m,ethod of the program
    Created 03-Dec-2020
    Author Roisin Kelly
*/
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Commented out code for the unit test class
            //FibonacciUnitTestClass fibTest = new FibonacciUnitTestClass();
            //if(fibTest.passed == true)
            //{
            //    Console.WriteLine("Passed fibonacci unit testing");
            //}
            //else
            //{
            //    Console.WriteLine("Failed fibonacci unit testing");
            //}
            // As this is the main method, I have minimised the code here for best practises
            Processing proc = new Processing();
            proc.StartProcessing();

        }
    }
}
