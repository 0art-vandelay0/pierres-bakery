using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

namespace Bakery.Models
{
    public class Program
    {
        public static void Main()
        {
            Intro();
            int breadQuantity = GetBreadInput();
            int pastryQuantity = GetPastryInput();

            Bread breadOrder = new Bread(breadQuantity);
            Pastry pastryOrder = new Pastry(pastryQuantity);

            int breadTotalPrice = breadOrder.BreadTotalPrice();
            int pastryTotalPrice = pastryOrder.PastryTotalPrice();
            int totalPrice = breadTotalPrice + pastryTotalPrice;

            PrintCheckOut(breadQuantity, breadTotalPrice, pastryQuantity, pastryTotalPrice, totalPrice);
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
            string orderMessage = "Would you like to purchase bread? y/n";
            int breadQuantity = GetInput(orderMessage);
            return breadQuantity;
        }

        public static int GetPastryInput()
        {
            string orderMessage = "Would you like to purchase pastry? y/n";
            int pastryQuantity = GetInput(orderMessage);
            return pastryQuantity;
        }

        public static int GetInput(string orderMessage)
        {
            Console.WriteLine(orderMessage);
            string orderQuantity = Console.ReadLine();
            try
            {
                if (orderQuantity == "y" || orderQuantity == "Y")
                {
                    Console.WriteLine("How many would you like?");
                    int quantity = int.Parse(Console.ReadLine());
                    return quantity;
                }
                else if (orderQuantity == "n" || orderQuantity == "N")
                {
                    return 0;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (System.Exception)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠  Error processing your input '" + orderQuantity + "' ⚠");
                Console.WriteLine("Please enter a valid response of y or n.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Try again...");
                Console.ResetColor();
                return GetInput(orderMessage);
            }
        }

        public static void PrintCheckOut(int breadQuantity, int breadTotalPrice, int pastryQuantity, int pastryTotalPrice, int totalPrice)
        {
            if (totalPrice == 0)
            {
                Console.WriteLine("-----------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                             ");
                Console.WriteLine("        – Receipt –          ");
                Console.WriteLine("                             ");
                Console.ResetColor();
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" \u2049 No items were purchased. \u2049");
            }
            else
            {
                Console.WriteLine("-----------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                             ");
                Console.WriteLine("        – Receipt –          ");
                Console.WriteLine("                             ");
                Console.ResetColor();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Bread Quantity: " + breadQuantity);
                Console.WriteLine("Bread Total Price: $" + breadTotalPrice);
                Console.WriteLine("Pastry Quantity: " + pastryQuantity);
                Console.WriteLine("Pastry Total Price: $" + pastryTotalPrice);
                Console.WriteLine("Total Price: $" + totalPrice);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Thank you for your purchase!");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}