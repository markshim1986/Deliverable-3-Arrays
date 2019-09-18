// Author: Mark Shim
// Date: 9/17/19
// Comments: Creating a C# Console Application which uses an 
// array to auto populate information
using System;

namespace Deliverable_3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementing a try-catch statement to catch any exceptions
            try
            {
                // Declaing my variable and the elements in my array

                int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                foreach (int i in numbers)
                {
                    Console.WriteLine("Element Value = " + i);
                }
                Console.WriteLine("\n Press any key to exit the program");
                Console.ReadKey(true);
            }
            catch
            {

            }
        }
    }
}

         

    
     
