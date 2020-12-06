using System;
using System.Collections.Generic;
/*
    Processing Class
    This Class is designed to interact with the user through CMD input
    Created 03-Dec-2020
    Author Roisin Kelly
*/

namespace Fibonacci
{
    class Processing
    {
        //this list is best used when there are multiple requests from the user, to reduce the computational needs by reusing the list as often as possible.
        private List<int> f = new List<int>();
        //this takes the value of the Nth number
        private int n;
        //Used when number is negative
        private bool NegNum = false;

        public void StartProcessing()
        {
            //this is to take input from the user to see if they want to enter another number
            string another;
            int anotherNum = -1;
            //this is the true/false value to check if the user want to enter another number, it is set at true for the first number by default
            bool enterAnother = true;
            //as the first 2 numers of the sequence are known I have added them to the list to begin with
            f.Add(0);
            f.Add(1);
            //This loop will keep going until the user opts not to input any more numbers
            while (enterAnother == true)
            {
                //If the loop is not on its first pass
                if (n != anotherNum && anotherNum != -1)
                {
                    n = anotherNum;
                }
                else
                {
                    //calling the get number function from this class 
                    this.getNumb();
                }

                //this if statement checks to see if we need to calculate more of the fibbonacci sequence than what has already been calculated
                if (f.Count <= n)
                {
                    //calling the method in this class that manages the calculation of the Fibbonacci Sequence
                    this.fibOutput();
                }
                if (NegNum == false)
                {
                    //Prints out the nth number of the fibonacci sequence
                    Console.WriteLine("The " + n + "th number of the Fibbonacci Sequence is: " + f[n].ToString());
                }
                else
                {
                    //This is to return the negative number of the Fibonacci Sequence which is an inversion of the positive number
                    int neg = -f[n];
                    //output the negative number from the fibbonacci sequence
                    Console.WriteLine("The " + (-n) + "th number of the Fibbonacci Sequence is: " +neg.ToString());
                    //reset the negative number to false for the next loop/number entered
                    NegNum = false;
                }
                //Starts a new line for the input
                Console.WriteLine();
                //Asks the user if they would like to enter another number
                Console.WriteLine("Would you like to enter another? Y/N");
                //Reads in the input from the user
                another = Console.ReadLine();
                //Validates if the  user entered Yes or Y
                if (another.ToUpper() != "YES" && another.ToUpper() != "Y")
                {
                    //This try catch is in the event the user has entered a number
                    try
                    {   //tries to convert the input from the user to a number
                        anotherNum = Int32.Parse(another);
                    }
                    catch (FormatException)
                    {
                        //this is in the event the user entered anything other than a number or yes or no
                        enterAnother = false;
                    }
                }

            }
        }
        //This method askes the user for input of a number and once the user enters an input it is taken in as a string and then we validate if the user has entered a number 
        //by trying to convert it to an int
        private void getNumb()
        {
            //the string that is used to capture the initial input from the user
            string nString;
            //this true/false value is used to ask the user for input and then validated
            bool isNum = false;
            //Prints out to the user to ask for the number from the fibbonacci sequence
            Console.WriteLine("Please Enter the Nth number you want to retreive.");

            while (isNum == false)
            {
                //Reads in the input from the user
                nString = Console.ReadLine();
                //Using a try catch statement in the event the user enters a word instead of a number
                try
                {
                    //Converts the number to an Int
                    n = Int32.Parse(nString);
                    //if there is an input less than 0 then ask the user to input a number greater than 0
                    if (n < 0)
                    {
                        NegNum = true;
                        n = -n;
                    }
                    
                        //if there is no error in converting the input to an int then the inNum value is set to true and exiting the loop
                        isNum = true;
                }
                catch (FormatException)
                {
                    //if there is an error in converting the input to an int then the following will be printed on the screen to the user and the loop will start again
                    Console.WriteLine("Please enter a numerical value, eg. 1");
                }
            }

        }
        //This method declares and creates an instance of the fibbonacci class and calls the methods needed to calculate the Fibbonacci Secuence and get the part of the sequence calculated returned 
        private void fibOutput()
        {
            //Declare & create instance of a class
            FibonacciClass fib = new FibonacciClass(f);
            //Calls the method to calculate the fibbonacci sequence
            fib.CalculateFibonacci(n);
            //Get the sequence calculated returned back to the class for display
            f = fib.getFib();

        }
    }
}