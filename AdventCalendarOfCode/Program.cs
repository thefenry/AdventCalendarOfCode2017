﻿using System;

namespace AdventCalendarOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {

                //Console.WriteLine(InverseCaptcha.CheckSum(input));
                //Console.WriteLine(InverseCaptchaPart2.CheckSum(input));
                //Console.WriteLine(SpreadSheetCheckSum.GetSpreadsheetChecksum(input));
                Console.WriteLine(SpreadSheetCheckSum.GetSpreadsheetDivisibleChecksum(input));



                input = Console.ReadLine();
            }

        }
    }
}
