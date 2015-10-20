using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.Console;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ch06_FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person(30000M) { FirstName = "Alice", LastName = "Smith", DateOfBirth = new DateTime(1974, 3, 14) },
                new Person(40000M) { FirstName = "Bob", LastName = "Jones", DateOfBirth = new DateTime(1969, 11, 23) },
                new Person(20000M) {
                    FirstName = "Charlie",
                    LastName = "Rose",
                    DateOfBirth = new DateTime(1964, 5, 4),
                    Children = new HashSet<Person> {
                        new Person(0M) { FirstName="Sally", LastName="Rose", DateOfBirth=new DateTime(1990, 7, 12) }
                    }
                }
            };

            var binaryFilepath = @"C:\Code\Ch06_People1.bin";
            var binaryStream = File.Create(binaryFilepath);
            var bf = new BinaryFormatter();
            bf.Serialize(binaryStream, people);
            WriteLine($"Written {new FileInfo(binaryFilepath).Length} bytes of proprietary binary to {binaryFilepath}");
            WriteLine();
            binaryStream.Close();
            binaryStream.Dispose();
            // Display the serialized object graph
            WriteLine(File.ReadAllText(binaryFilepath));

        }
    }
}
