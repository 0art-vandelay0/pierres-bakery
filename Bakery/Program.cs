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
            int breadQuantity = GetBreadInput();

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
            Console.WriteLine("-----------------------------");


            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                             ");
            Console.WriteLine("       🍰  Pastries 🍰       ");
            Console.WriteLine("  $2 ea | Buy 4, Get 1 Free  ");
            Console.WriteLine("                             ");
            Console.WriteLine("         🍞 Bread 🍞         ");
            Console.WriteLine("  $5 ea | Buy 3, Get 1 Free  ");
            Console.WriteLine("                             ");
            Console.ResetColor();
            Console.WriteLine(" \n ");
        }

        public static int GetBreadInput()
        {
            Console.WriteLine("Would you like to purchase bread? y/n");
            string breadResponse = Console.ReadLine();
            try
            {
                if (breadResponse == "y" || breadResponse == "Y")
                {
                    Console.WriteLine("How many loaves of bread would you like to purchase?");
                    int breadQuantity = int.Parse(Console.ReadLine());
                    return breadQuantity;
                }
                else if (breadResponse == "n" || breadResponse == "N")
                {
                    return 0;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠  Error processing your input '" + breadResponse + "' ⚠");
                Console.WriteLine("Please enter a valid response of y or n.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Try again...");
                Console.WriteLine("\n");
                Console.ResetColor();
                return GetBreadInput();
            }
        }
    }
}