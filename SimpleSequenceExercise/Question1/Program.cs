using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Question1
    //NEW NEW NEWdsfdsfsdfds
{
    //1.	The West Coast sales unit of a company generates 43 percent of the company’s total sales.Based on this percentage, write a program that will determine how much the West Coast unit will generate if the company has $5.3 million in sales this year.
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SALES_UNIT_PERCENT = .43;
            double answer;

            answer = 5300000 * SALES_UNIT_PERCENT;
            Console.WriteLine($"The money generated is {answer:C}");
        }
    }
}
