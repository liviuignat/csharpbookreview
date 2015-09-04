using Packt.LearningCS;
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch04_PeopleApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            var p1 = new Person();
            WriteLine(p1.ToString());
        }
    }
}
