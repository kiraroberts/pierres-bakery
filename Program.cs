using System;
using System.Collections.Generic;
using Bakery.Deals;

namespace Bakery
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Welcome to Pierre's Bakery! We have loaves of bread for 5 dollars and pastries for 2 dollars.");
            Console.WriteLine("Our deals today are buy two loaves get one free, and 5 dollars for 3 pastries.");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("How many loaves of bread would you like to order?");
            int BreadInput = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("How many pastries would you like to order?");
            int PastryInput = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Bread newBread = new Bread(BreadInput, 0);
            Pastry newPastry = new Pastry(PastryInput, 0);
            newBread.BreadDeal(BreadInput);
            newPastry.PastryDeal(PastryInput);
            int Checkout = newPastry.PastryTotal + newBread.BreadTotal;
            Console.WriteLine("Your total is: $" + Checkout);
            Console.WriteLine("------------------------------------");
        }
    }
}