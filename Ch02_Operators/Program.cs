using System;
using static System.Console;

namespace Ch02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("What is your name? ");
            string name = ReadLine();
            WriteLine($"{name} is {name?.Length} letters long.");
            WriteLine();
            WriteLine("Incrementing");
            int x = 3;
            WriteLine(x);
            x++;
            WriteLine(x);
            WriteLine();
            WriteLine("Changing precedence order");
            var MultiplyThenSubtract = 3 * 6 - 2;
            var SubtractThenMultiply = 3 * (6 - 2);
            WriteLine($"{MultiplyThenSubtract}, {SubtractThenMultiply}");

        }
    }
}
