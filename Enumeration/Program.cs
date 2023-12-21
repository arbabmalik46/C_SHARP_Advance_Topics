using System;
using System.IO.Enumeration;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Principal;
using Enumeration.Enum;

namespace Enumeration
{

    class Program
    {
        public static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Green; //ConsoleColor is enum and Green is constant value
            //Console.ForegroundColor = ConsoleColor.White; //ConsoleColor is enum and Blue is constant value
            Console.WriteLine("Hi, My Name Is Arbab and I was Born on 11th of {0}, 1999",Month.September);
            Month month = Month.May;
            switch (month)
            {
                case Month.January:
                    Console.WriteLine("January");
                    break;
                case Month.Feburary:
                    Console.WriteLine("January");
                    break;
                case Month.March:
                    Console.WriteLine("January");
                    break;
                case Month.April:
                    break;
                case Month.May:
                    break;
                case Month.June:
                    break;
                case Month.July:
                    break;
                case Month.August:
                    break;
                case Month.September:
                    break;
                case Month.October:
                    break;
                case Month.November:
                    break;
                case Month.December:
                    break;
                default:
                    break;
            }
            Console.WriteLine(Month.May.ToString());
        }
    }
}