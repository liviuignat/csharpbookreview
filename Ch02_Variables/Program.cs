using static System.Console;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var population = 66000000;
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true;

            int ICannotBeNull = 4;
            ICannotBeNull = default(int); // 0
            int? ICouldBeNull = null;
            var result1 = ICouldBeNull.GetValueOrDefault(); // 0
            ICouldBeNull = 4;
            var result2 = ICouldBeNull.GetValueOrDefault(); // 4 

            // this only works with C# 6.0 or later
            Write($"The population of the UK is {population}. ");
            WriteLine($"The population of the UK is {population:N0}. ");
            WriteLine($"{weight}kg of {fruit} costs {price:C}. ");

            // this works in all versions of C#
            Write("The population of the UK is {0}. ", population);
            WriteLine("The population of the UK is {0:N0}. ",
                population);
            WriteLine("{0} kilos of {0} costs {0:C}. ",
                weight, fruit, price);

            Write("Type your name and press ENTER: ");
            string name = ReadLine();
            Write("Type your age and press ENTER: ");
            string age = ReadLine();
            WriteLine($"Hello {name}, you look good for {age}.");


        }
    }
}
