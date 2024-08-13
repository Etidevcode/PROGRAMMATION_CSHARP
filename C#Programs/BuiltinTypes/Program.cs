namespace BuiltinTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte: minimum {byte.MinValue}, maximum {byte.MaxValue}");
            Console.WriteLine($"sbyte: minimum {sbyte.MinValue}, maximum {sbyte.MaxValue}");
            Console.WriteLine($"short: minimum {short.MinValue}, maximum {short.MaxValue}");

            Console.WriteLine();
            var x = 234;
            Console.WriteLine(x.GetType());
            // Console.WriteLine(x.GetType().ToString());

            Console.WriteLine();
            Console.WriteLine($"int: minimum {int.MinValue}, maximum {int.MaxValue}");
            Console.WriteLine($"long: minimum {long.MinValue}, maximum {long.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"float: minimum {float.MinValue}, maximum {float.MaxValue}");
            Console.WriteLine($"double: minimum {double.MinValue}, maximum {double.MaxValue}");

            Console.WriteLine();
            float f = 123.456789012345678f;
            double d = 123.456789012345678;
            Console.WriteLine($"f is {f:F99}");
            Console.WriteLine($"d is {d:F99}");
            Console.WriteLine();

            Console.WriteLine();
            var y = 123.4;
            Console.WriteLine(y.GetType());
            Console.WriteLine();

            decimal z = 123.4567890123456789012345678901234567890123456789m;
            Console.WriteLine();
            Console.WriteLine($"decimal: minimum {decimal.MinValue}, maximum {decimal.MaxValue}");
            Console.WriteLine($"z is {z:F99}");

        }
    }
}
