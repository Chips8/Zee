﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cans_Ver._2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration of variables
            int numOfCans, numOfCases, numOfCansInCase;
            decimal pricePerCan;
            double discountPercentage;
          
            // prompting user input
            Console.Write("Enter price for 1 can ");
            pricePerCan = decimal.Parse(Console.ReadLine());

            Console.Write("Enter # of cans: ");
            numOfCans = int.Parse(Console.ReadLine());

            Console.Write("Enter Discount for purchasing in cases. It should be between 0 and 1. e.g. 5% = 0.05 : ");
            discountPercentage = double.Parse(Console.ReadLine());

            Console.Write("Please enter the amount of cases: ");
            numOfCases = int.Parse(Console.ReadLine());

            Console.Write("Please enter the amount of cans in 1 case: ");
            numOfCansInCase = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of cases to purchase: ");

            // calculations
            decimal discountPricePerCan = pricePerCan - (pricePerCan * (decimal)discountPercentage);

            decimal totalCost = discountPricePerCan * (numOfCases * numOfCansInCase);
            
            // display
            Console.WriteLine($"The price for {numOfCans} is {totalCost:c}");
            Console.WriteLine("Price for {0} cans is ${1:0.000}", numOfCans, totalCost);
            Console.ReadLine();
        }
    }
}
