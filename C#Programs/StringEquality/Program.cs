namespace StringEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String first = "This is a string";
            String second = "THIS IS A STRING";
            Console.WriteLine(first == second);
            Console.WriteLine(second == first);
            Console.WriteLine(first.Equals(second, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(second.Equals(first, StringComparison.OrdinalIgnoreCase));

        }
    }
}
