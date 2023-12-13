using System;
using System.Diagnostics;

namespace fib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Seka obj = new Seka(Math.Pow(10, 15));
            obj.Skaiciavimas(); // objekto iškvietimas

            stopwatch.Stop();
            Console.WriteLine("Laikas kuris truko: " + stopwatch.Elapsed); // Veikimo laikas

            Console.ReadLine();
        }
    }
}
