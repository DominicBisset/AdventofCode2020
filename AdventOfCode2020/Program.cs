using System;
using System.Collections.Generic;
using AdventOfCode.Lib.Helpers;
using AdventOfCode.Lib.Puzzles.Day1;
using AdventOfCode.Lib.Puzzles.Day2;
using AdventOfCode.Lib.Puzzles.Day3;
using AdventOfCode.Lib.Puzzles.Day4;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {

            //SolveDay1();
            //SolveDay2();
            //SolveDay3();
            SolveDay4();
        }

        private static void SolveDay1()
        {
            IntData data = new IntData(".\\Data\\Day1a.txt");
            Day1 day = new Day1(data);
            Console.WriteLine("Day1");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void SolveDay2()
        {
            StringData data = new StringData(".\\Data\\Day2a.txt");
            Day2 day = new Day2(data);
            Console.WriteLine("Day2");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private static void SolveDay3()
        {
            StringData data = new StringData(".\\Data\\Day3a.txt");
            Day3 day = new Day3(data);
            Console.WriteLine("Day3");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private static void SolveDay4()
        {
            StringData data = new StringData(".\\Data\\Day4a.txt");
            Day4 day = new Day4(data);
            Console.WriteLine("Day4");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
