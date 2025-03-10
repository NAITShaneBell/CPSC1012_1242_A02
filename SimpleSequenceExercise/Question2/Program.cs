using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        //2.One acre of land is equivalent to 43,560 square feet. Write a program that calculates the number of acres in a tract of land with a user provided value of square feet.
        //const for ONE_ACRE_SQFT
        //double variable for the user provided square feet
        //double variable for answer
        //prompt and read the square feet
        //calculate the number of acres (user square feet/ONE_ACRE_SQFT) and place in answer variable
        //display the answer


        static void Main(string[] args)
        {
            const double ONE_ACRE_SQFT = 43560;
            double userSqFt, answer;
            Console.Write("How many square feet? ");
            userSqFt = double.Parse(Console.ReadLine());

            answer = userSqFt / ONE_ACRE_SQFT;            

            Console.WriteLine($"{userSqFt} is {answer} acres");
        }
    }
}
