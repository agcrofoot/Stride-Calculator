using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Alexandra says hello");

            //define variables
            int height = 0;
            int steps = 0;
            double CON_FAC = 0.413;
            int FEET_IN_MILE = 5280;
            double strideLength = 0.0;
            double feetWalked = 0.0;
            double milesWalked = 0.0;

            //prompt for height
            Console.WriteLine("Please Enter Your Height In Inches.");
            height = int.Parse(Console.ReadLine());

            //prompt for steps
            Console.WriteLine("Please Enter The Number Of Steps You Take In A Day.");
            steps = int.Parse(Console.ReadLine());

            //calculate stride length in inches
            strideLength = height * CON_FAC;

            //calculate stride length in feet
            strideLength = strideLength / 12;

            //calculate feet walked
            feetWalked = strideLength * steps;

            //calculate miles walked
            milesWalked = feetWalked / FEET_IN_MILE;

            //display the number of miles walked
            Console.WriteLine("You Walked " + milesWalked + " Miles.");

        }
    }
}
