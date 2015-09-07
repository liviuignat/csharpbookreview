using System;
using static System.Console;
using Packt.LearningCS;

namespace Ch04_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person { Name = "Alice Jones", DateOfBirth = new DateTime(1998, 3, 17) };
            p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");

            p1.Children.Add(new Person());
            p1.Children.Add(new Person());
            WriteLine($"  {p1.Name} has {p1.Children.Count} children.");

            BankAccount.InterestRate = 0.012M;
            var ba1 = new BankAccount();
            ba1.AccountName = "Mrs. Jones";
            ba1.Balance = 2400;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate} interest.");
            var ba2 = new BankAccount();
            ba2.AccountName = "Ms. Gerrier";
            ba2.Balance = 98;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate} interest.");


            var p3 = new Person();
            WriteLine($"{p1.Name} was instantiated at {p1.Instantiated:hh:mm:ss} on {p1.Instantiated:dddd, d MMMM yyyy}");

            var p4 = new Person("Aziz");
            WriteLine($"{p1.Name} was instantiated at {p1.Instantiated:hh:mm:ss} on {p1.Instantiated:dddd, d MMMM yyyy}");

            p1.WriteToConsole();
            WriteLine(p1.GetOrigin());

            WriteLine(p1.SayHello());
            WriteLine(p1.SayHelloTo("Emily"));

            p1.OptionalParameters();
            p1.OptionalParameters("Jump!", 98.5);
            p1.OptionalParameters(number: 52.7, command: "Hide!");
            p1.OptionalParameters("Poke!", active: false);

            var max = new Person { Name = "Max", DateOfBirth = new DateTime(1972, 1, 27) };
            WriteLine(max.Origin);
            WriteLine(max.Greeting);
            WriteLine(max.Age);

            max.FavouriteIceCream = "Chocolate Fudge";
            WriteLine($"Max's favourite ice-cream flavour is {max.FavouriteIceCream}.");
            max.FavouritePrimaryColour = "Red";
            WriteLine($"Max's favourite primary colour is {max.FavouritePrimaryColour}.");

            max.Children.Add(new Person { Name = "Charlie" });
            max.Children.Add(new Person { Name = "Ella" });
            WriteLine($"Max's first child is {max.Children[0].Name}");
            WriteLine($"Max's second child is {max.Children[1].Name}");
            WriteLine($"Max's first child is {max[0].Name}");
            WriteLine($"Max's second child is {max[1].Name}");


        }
    }
}
