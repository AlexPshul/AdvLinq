using AdvLinq;
using System;
using System.Linq;

namespace Test.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Enumerable
                .Range(1, 100)
                .Select(_ => r.Next(1, 100))
                .SelectIf(number => number > 50, _ => "Bigger", _ => "Smaller")
                .ForEach(Console.WriteLine);
        }
    }
}