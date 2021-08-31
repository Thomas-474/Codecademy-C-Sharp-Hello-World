using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecademy_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thomas");

            // this is a comment
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");

            Console.ReadKey();
        }
    }
}
