using System;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Hi = "SDE-1";
            int num= 101;
            char Hey = 'A';
            bool AreYouSde= true;
            double TheDec = 10.0;
            decimal num2 = 10000;
            long num3 = 1000000000000;

            Console.WriteLine();
            Console.WriteLine($"Hello, {Hi}. Welcome to Software Engineering {num}{Hey}!");
            Console.WriteLine($"Are you an SDE? {AreYouSde}. If so what's your power? {num2}. What's your rank? {TheDec}");
            Console.WriteLine($"Ambition level? {num3}");

        }
    }
}
