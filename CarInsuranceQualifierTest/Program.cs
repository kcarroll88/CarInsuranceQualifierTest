﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceQualifierTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please use true or false.");
            bool dui = bool.Parse(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool qualified = (age > 15) && (dui == false) && (tickets <= 3);
            Console.WriteLine("Are you qualified? " + qualified);

            Console.Read();


        }
    }
}
