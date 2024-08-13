namespace SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            char userChoice = ' ';

            Console.WriteLine("Please choose one the following options");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Americano");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Mac");
            Console.WriteLine("6 - Macchiato");
            Console.WriteLine("7 - Expresso");
            Console.WriteLine("Q - Quit the program");




            // while (!userChoice.Equals('q'))
            // while(!(userChoice.Equals('q') || userChoice.Equals('Q')))

            do
            {

                userChoice = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You choose " + userChoice);

                switch(userChoice)
                {
                    case '1': 
                    case '2':
                        Console.WriteLine("Making Latte...");
                        Console.WriteLine("Make espresso");
                        Console.WriteLine("Steam the milk");
                        Console.WriteLine("Add the milk to the espresso");
                        break;

                    case '3':
                        Console.WriteLine("Making Americano...");
                        break;

                    case '4':
                        Console.WriteLine("Making Mocha...");
                        break;

                    case '5':
                        Console.WriteLine("Making Macchiato...");
                        break;

                    case '6':
                        Console.WriteLine("Making Expresso...");
                        break;

                    default:
                        Console.WriteLine("Return coins");
                        continue;
                }
                Console.WriteLine("Dispensing coffee");
                Console.WriteLine("Have a nice day");

                /*
                var x = userChoice.Key;
                char y = userChoice.KeyChar;
                var z = userChoice.Modifiers;
                Console.WriteLine("Key: " + x);
                Console.WriteLine("KeyChar: " + y);
                Console.WriteLine("Modifiers: " + z);
                */
            } while (!userChoice.Equals('q'));







        }

    }
}
