using System.Collections.Generic;
/*
    Fibonacci Unit Test class 
    Created 03-Dec-2020
    Author Roisin Kelly
*/
namespace Fibonacci
{
    class FibonacciUnitTestClass
    {
        //List of the known correct fibonacci Sequence
        private List<int> fib = new List<int>();
        //List of the calculate fibonacci sequence
        private List<int> fibReturned = new List<int>();
        //To indicate if the unit test passed or failed
        public bool passed = true;
        //constructor method to run the unit test
        public FibonacciUnitTestClass()
        {
            //Calls method to create list of known fibonacci sequence
            this.CreateList();
            //Calls the class methods to get the calculated fibonacci sequence
            this.testClass();
            //Calls the method to compare the 2 lists
            this.compareLists();
        }

        //values added to the list is retreived from https://www.mathsisfun.com/numbers/fibonacci-sequence.html
        private void CreateList()
        {
            fib.Add(0);
            fib.Add(1);
            fib.Add(1);
            fib.Add(2);
            fib.Add(3);
            fib.Add(5);
            fib.Add(8);
            fib.Add(13);
            fib.Add(21);
            fib.Add(34);
            fib.Add(55);
            fib.Add(89);
            fib.Add(144);
            fib.Add(233);
            fib.Add(377);
            fib.Add(610);
            fib.Add(987);
            fib.Add(1597);
            fib.Add(2584);
            fib.Add(4181);
            fib.Add(6765);
            fib.Add(10946);
            fib.Add(17711);
            fib.Add(28657);
            fib.Add(46368);
            fib.Add(75025);
            fib.Add(121393);
            fib.Add(196418);
            fib.Add(317811);
        }
        //calls the Fibonacci Class to calculate the the fibonacci sequence and gets the list back
        private void testClass()
        {
            fibReturned.Add(0);
            fibReturned.Add(1);
            FibonacciClass fibClass = new FibonacciClass(fibReturned);
            fibClass.CalculateFibonacci((fib.Count - 1));
            fibReturned = fibClass.getFib();


        }
        //this method compares the 2 lists returned if they are the same the unit test has passed, otherwise the test fails
        private void compareLists()
        {
            //checks if the length of the lists  are the same
            if (fib.Count == fibReturned.Count)
            {
                //loops until we reach  the end of the list, used a  for (int i = 0; i < fib.Count; i++) instead of foreach(var f in fib) as the latter would require a nested loop
                for (int i = 0; i < fib.Count; i++)
                {
                    if (passed != false)
                    {
                        //checks if the items at index I are not equal
                        if (fib[i] != fibReturned[i])
                        {
                            //if items at index i is not equal to each other then the test has failed
                            passed = false;
                            //setting the index to the list count to exit count as the test has failed and there if no point in checking the rest of the values
                            i = fib.Count;
                        }
                    }
                }
            }
            else
            {
                //as the lists have different lengths the test has failed
                passed = false;
            }
        }
    }
}
