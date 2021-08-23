using System;
using Shared.Solutions;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Console App started with args: {string.Join(", ", args)}");
            var solution = new HelloWorld();
            solution.Run();
        }
    }
}
