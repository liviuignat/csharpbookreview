using System;
using static System.Console;
using static System.Convert;

namespace Ch02_CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;
            WriteLine(b);


            double c = 9.8;
            //int d = c; // compiler gives an error for this line
            int d = (int)c;
            WriteLine(d);


            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e} and f is {f}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e} and f is {f}");

            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            var number = 12;
            WriteLine(number.ToString());
            var boolean = true;
            WriteLine(boolean.ToString());
            var now = DateTime.Now;
            WriteLine(now.ToString());
            var me = new object();
            WriteLine(me.ToString());



        }
    }
}
