using System;

namespace fib
{
    public class Seka
    {
        private double a = 2;
        private double b = 1;
        private double fib = 0;
        private double limit;

        public Seka(double newLimit)
        {
            limit = newLimit;
        }

        public void Skaiciavimas()
        {
            while (fib <= limit)
            {
                fib = a * b;
                Console.WriteLine(fib); // Išvedimas fib rezultatas
                a = b;
                b = fib;
            }

            Console.WriteLine("Paskutinė reikmė iki limito : " + a);
            Console.WriteLine("Paskutinė reikmė po limito : " + b);
        }
    }
}
