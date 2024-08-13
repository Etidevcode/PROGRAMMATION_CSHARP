using System.Runtime.CompilerServices;

namespace StringExamples3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String courseName = "Learn C# for Beginners Crash Course";

            int position = -1;

            /*
            position = courseName.IndexOf(" c", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(position);
            position = courseName.LastIndexOf(" c", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(position);
            */

            do
            {
                position = courseName.IndexOf(" c", position + 1, StringComparison.OrdinalIgnoreCase);
                if (position != -1)
                {
                    courseName = ReplaceByIndex(courseName, position, " c".Length, " Java");
                    Console.WriteLine(courseName);
                }
            } while (position != -1);

            String fixedString = courseName.Replace(" Java", " C");
            Console.WriteLine(fixedString);
        }
         private static string ReplaceByIndex(string original, int start, int length, string replacement)
         {
            String newString = original.Remove(start, length);
            return newString.Insert(start, replacement);
         }
    }
}
