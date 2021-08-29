using System;

namespace color
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("каждый охотник желает знать где сидит фазан");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("");
            Console.ResetColor();

        }
    }
}
