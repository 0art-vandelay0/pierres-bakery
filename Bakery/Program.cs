using System;
using System.Collections.Generic;
using System.Reflection;

namespace Bakery.Models
{
    public class Program
    {
        public static void Main()
        {
            Intro();

            // GetInputs()
            // CalculateTotalPrice()
            // PrintCheckOut()
        }

        public static void Intro()
        {
            Console.WriteLine("-----------------------------");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" □ □ □ Pierre's Bakery □ □ □ ");
            Console.ResetColor();
            Console.WriteLine("-----------------------------");

            Console.WriteLine("-----------------------------");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           – Menu –          ");
            Console.ResetColor();
            Console.WriteLine("-----------------------------\n ");
            Console.WriteLine("      🍰  Pastries 🍰      ");
            Console.WriteLine("$2 each | Buy 4, Get 1 Free\n");


            Console.WriteLine("        🍞 Bread 🍞       ");
            Console.WriteLine("$5 each | Buy 3, Get 1 Free\n");
        }
    }
}