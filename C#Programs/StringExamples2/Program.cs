namespace StringExamples2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string courseName = "Learn C# for Beginners Crash Course";
            string message = "Welcome to ";

            Console.WriteLine(courseName[0]);
            Console.WriteLine(courseName[7]);
            

            for (int i = 13; i < courseName.Length; i++)
            {
                Console.Write(courseName[i]);
            }
            Console.WriteLine();
            Console.WriteLine(courseName.Length);


        }
    }
}
