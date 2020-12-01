using System;
using System.Collections.Generic;
using AdventOfCode.Lib;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1();
        }

        private static void Day1()
        {
            List<int> day1aData = new Data(".\\Data\\Day1a.txt").AsListOfInts();
            Day1 day1 = new Day1();
            var output = day1.ExpensesAmount1A(day1aData);
            Console.WriteLine(output);
            output = day1.ExpensesAmount1B(day1aData);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
