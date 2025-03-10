using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        //3.	A bag of cookies holds 26 cookies.The calorie information on the bag claims that there are 10 servings in the bag and that each serving equals 175 calories.Write a program that lets the user enter the number of cookies he or she actually ate and then reports the number of total calories consumed.

        //const for cookiesperbag,servingsperbag, caloriesperserving
        //int userCookieCountVariable,
        //double variabel caloriesPerCookie, caloriesConsumed
        //prompt and read how many cookies consumed
        //Cacluate how many calories per cookie
        //multiply cookies consumed by calories per cookie
        //Display the calories

        //cookiesConsumed =3;
        //cookiesperbag/servingsperbag = 2.6
        //caloriesperCookie = caleriesperserving / 2.6 = 67.31
        //caleriespercookie*cookiesconsumed =201.93 calories

        static void Main(string[] args)
        {
            const int COOKIES_PER_BAG = 26;
            const int SERVINGS_PER_BAG = 10;
            const int CALORIES_PER_SERVING = 175;

            //const double CALORIES_PER_COOKIE = 175 / 26 / 10;



            double caloriesPerCookie, caloriesConsumed;
            int userCookieCount;

            Console.Write("How many cookies did you eat? ");
            userCookieCount=int.Parse(Console.ReadLine());  



            caloriesPerCookie = (double)CALORIES_PER_SERVING / ((double)COOKIES_PER_BAG / SERVINGS_PER_BAG);
            //caloriesPerCookie = 175 / 26 / 10;
            caloriesConsumed = caloriesPerCookie * userCookieCount;

            Console.Write($"If you are {userCookieCount} cookies, then you consumed {caloriesConsumed} calories"); 
            
            




















        }
    }
}
