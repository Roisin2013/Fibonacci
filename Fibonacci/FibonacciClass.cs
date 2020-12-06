using System.Collections.Generic;
/*
    Fibonacci Class
    This Class is designed to calculate the fibonnacci to the nth position
    Created 03-Dec-2020
    Author Roisin Kelly
*/

namespace Fibonacci
{
    class FibonacciClass
    {
        //private list of integers to store the fibonacci secuence
        private List<int> FibonacciSequence { set; get; }

        //constructor method to give values to the private variables
        public FibonacciClass( List<int> f)
        {
            //fills the values of the private variables
            FibonacciSequence = f;
        }

        //The following method is a recursive method designed to call itself until the next available fibonacci number is to be calculated
        public void CalculateFibonacci(int num)
        {
            //checks if we need to call the method more than once
            if (num > FibonacciSequence.Count)
            {
                //the method calling itself with the parameter (num-1)
                this.CalculateFibonacci(num - 1);
            }
            //calculate the next sequence in the Fibonacci sequence
            int fibEntry = (FibonacciSequence[(num - 1)]) + (FibonacciSequence[(num - 2)]);
            //Add the next number to the fibonacci sequence
            FibonacciSequence.Add(fibEntry);

        }
        //returns the fibonacci sequence where called
        public List<int> getFib()
        {
            return FibonacciSequence;
        }
    }
}
