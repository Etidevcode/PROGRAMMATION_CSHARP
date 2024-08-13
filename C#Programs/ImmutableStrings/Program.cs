using System.Text;

namespace ImmutableStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
            int x = 5;
            int y = x;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine($"x is the same as y: {object.ReferenceEquals(x, y)}");
           */

            StringBuilder first = new StringBuilder("This a string");
            StringBuilder second = new StringBuilder("This a string");

            Console.WriteLine($"first: {first}");

            Console.WriteLine("Clearing first...");
            /*
            first.Length = 0;
            Console.WriteLine($"first: *{first}*");

            first.Append("Another string");
            */
            if (first.Clear() == first)
            {
                Console.WriteLine("The references are the same");
            }
            if (object.ReferenceEquals(first.Clear(), first))
            {
                Console.WriteLine("The references are the same");
            }

            StringBuilder checkReference = first.Clear();

            if (checkReference == first)
            {
                Console.WriteLine("The references are the same");
            }

            first.Append("Another string");
            // first.Clear().Append("Another string");
            first.Clear().Append("Another string").Append(" ").Append(second);
            Console.WriteLine($"first: *{first}*");
            Console.WriteLine($"checkReference: *{checkReference}*");


            /*
            string first = "This is a string";
            string second = first;
            
            Console.WriteLine($"first: {first}");
            Console.WriteLine($"second: {second}");
            Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");

            Console.WriteLine();

            first = first.Remove(4, 5);
            // first = first.Insert(4, " is a");
          
            Console.WriteLine($"second: {second}");
            Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");
            Console.WriteLine($"first == second: {first == second}");
            Console.WriteLine($"first .Equals second: {first.Equals(second)}");
            */




        }
    }
}
