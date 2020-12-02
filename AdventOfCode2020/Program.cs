using System;
using System.Collections.Generic;
using AdventOfCode.Lib;
using AdventOfCode.Lib.Day2;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Day2();
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

        private static void Day2()
        {
            List<string> data = new Data(".\\Data\\Day2a.txt").AsListOfStrings();
            Day2 day2 = new Day2();
            var output = day2.CountPasswordsCorrect2A(data);
            Console.WriteLine(output);
            output = day2.CountPasswordsCorrect2B(data);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
