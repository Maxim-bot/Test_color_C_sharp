using System;

namespace color
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("каждый охотник желает знать где сидит фазан");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("каждый ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("охотник ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("желает ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("знать ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("где ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("сидит ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("фазан ");
            Console.ResetColor();

        }
    }
}
