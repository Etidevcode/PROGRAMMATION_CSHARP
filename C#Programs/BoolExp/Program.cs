namespace BoolExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int apples = 6;
            int oranges = 9;
            decimal applePrice = 12.60m;
            decimal orangePrice = 4.50m;

            bool moreApples;
            bool applesAreaDearer;

            // Compound Boolean Expressions

            Console.WriteLine(apples == oranges);
            Console.WriteLine(apples !=  oranges);
            Console.WriteLine($"{apples} > {oranges} is {apples > oranges}");
            Console.WriteLine($"{apples} < {oranges} is {apples < oranges}");
            Console.WriteLine($"{apples} >= {oranges} is {apples >= oranges}");
            Console.WriteLine($"{apples} <= {oranges} is {apples <= oranges}");
            Console.WriteLine($"{apples} is int  is {apples is int}");

            Console.WriteLine();
            Console.WriteLine($"Reducing apple cost: {(apples > oranges) && (applePrice > orangePrice)}");
            Console.WriteLine($"Reducing apple cost: {(apples > oranges) || (applePrice > orangePrice)}");

            
            // Boolean Variables
            moreApples = (apples > oranges);
            applesAreaDearer = (applePrice > orangePrice);
            Console.WriteLine();
            Console.WriteLine($"We have more apples : {moreApples}");
            Console.WriteLine($"Apples are dearer : {applesAreaDearer}");

            Console.WriteLine();
            Console.WriteLine($"Reducing apple cost: {moreApples && applesAreaDearer}");
            Console.WriteLine($"Reducing apple cost: {moreApples || applesAreaDearer}");

            Console.WriteLine();
            bool moreApplesAndDearer = moreApples && applesAreaDearer;
            bool moreApplesOrDearer = moreApples || applesAreaDearer;
            Console.WriteLine($"Reducing apple cost: {moreApplesAndDearer}");
            Console.WriteLine($"Reducing apple cost: {moreApplesOrDearer}");

            bool trueValue = true;
            bool falseValue = false;

        }
    }
}
