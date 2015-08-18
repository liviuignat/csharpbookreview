using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02_CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                }
            }
            catch
            {
                WriteLine("The code overflowed but I caught the exception.");
            }

            unchecked
            {
                int x = int.MaxValue + 1;
                WriteLine(x);
                x--;
                WriteLine(x);
                x--;
            }
        }
    }
}
