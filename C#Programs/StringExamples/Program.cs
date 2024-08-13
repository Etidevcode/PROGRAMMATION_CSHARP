namespace StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string courseName = "Learn C# for Beginners Crash Course";
            string message = "Welcome to ";

            // Concatenate courseName and message to create a new string
            string fullMessage =  message + courseName;
            Console.WriteLine(fullMessage);

            // Use string interpolation
            string fullMessage2 = $"{message}{courseName}";
            Console.WriteLine(fullMessage2);

            // Use composite Formatting with methods that support it
            Console.WriteLine("Hello, and {0} the {1}", message, courseName);

            for (int i = 0; i < courseName.Length; i++)
            {
                char character = courseName[i];
                Console.WriteLine(character);
            }


        }
        
    }
}
