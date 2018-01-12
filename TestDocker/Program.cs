using System;
using System.Text;

namespace TestDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Args!");
            foreach (var arg in args)
            {
                Console.WriteLine($"Arg: {arg}");
            }
        }
    }
}
