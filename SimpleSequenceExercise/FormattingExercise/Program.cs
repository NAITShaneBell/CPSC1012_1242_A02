using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace FormattingExercise
{
    internal class Program
    {
        //1.	Prompt the user for their top 3 favorite restaurants, food items at each restaurant, and price of each item.Once all the values have been entered, display the values in three columns. The first 2 columns will be left aligned and 20 columns wide. The price column will be right aligned and 10 columns wide. Format all prices to currency.
        //Once all the rows have been listed, display the total price of all the food items.

        //declare 3 restaurant, Food, and price variables
        //Prompt and read values for the vraiable
        //display in 3 columns
        //calculate the total of all the prices
        //Display the total of all the prices


        static void Main(string[] args)
        {
            string restaurant1, restaurant2, restaurant3;
            string favoriteFood1, favoriteFood2, favoriteFood3;
            double price1, price2, price3, totalPrices;

            Console.Write("What is your favorite restaurant? ");
            restaurant1 = Console.ReadLine();
            Console.Write("What is your favorite food there? ");
            favoriteFood1 = Console.ReadLine();
            Console.Write("What is the price of this food? ");
            price1 = double.Parse(Console.ReadLine());

            Console.Write("What is your favorite restaurant? ");
            restaurant2 = Console.ReadLine();
            Console.Write("What is your favorite food there? ");
            favoriteFood2 = Console.ReadLine();
            Console.Write("What is the price of this food? ");
            price2 = double.Parse(Console.ReadLine());

            Console.Write("What is your favorite restaurant? ");
            restaurant3 = Console.ReadLine();
            Console.Write("What is your favorite food there? ");
            favoriteFood3 = Console.ReadLine();
            Console.Write("What is the price of this food? ");
            price3 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{"RESTAURANT",-20}{"FOOD",-20}{"PRICE",10}");
            Console.WriteLine($"{restaurant1,-20}{favoriteFood1,-20}{price1,10:C}");
            Console.WriteLine($"{restaurant2,-20}{favoriteFood2,-20}{price2,10:C}");
            Console.WriteLine($"{restaurant3,-20}{favoriteFood3,-20}{price3,10:C}");
            Console.WriteLine();
            totalPrices = price1 + price2 + price3;
            Console.WriteLine($"The total of the prices for the food is {totalPrices:C}");



        }
    }
}
