﻿namespace GotoExample
{
    internal class SwichTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffee sizes: 1=Small 2=Medium 3=Large");
            Console.Write("Please enter your selection: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int cost = 0;

            // *********************************************
            // code that replaces switch and goto example
            // *********************************************

            if (n >= 1 && n <= 3)
            {
                cost = 25 * n;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
            // *********************************************

            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business.");

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    /*
    Sample Input:  2

    Sample Output:
    Coffee sizes: 1=Small 2=Medium 3=Large
    Please enter your selection: 2
    Please insert 50 cents.
    Thank you for your business.
    */

}

