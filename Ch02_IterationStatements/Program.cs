using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace Ch02_IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            x = 0;
            do
            {
                WriteLine(x);
                x++;
            } while (x < 10);

            for (x = 0; x < 10; x++)
            {
                WriteLine(x);
            }

            var numbers = new List<int> { 3, 9, 2, 7 };
            foreach (var number in numbers)
            {
                WriteLine($"The square of {number} is {number * number}");
            }

            IEnumerator e = numbers.GetEnumerator();
            while (e.MoveNext())
            {
                int number = (int)e.Current;
                WriteLine($"The square of {number} is {number * number}");
            }
        }
    }
}
