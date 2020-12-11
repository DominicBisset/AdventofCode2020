using System;
using System.Collections.Generic;
using AdventOfCode.Lib.Helpers;
using AdventOfCode.Lib.Puzzles.Day1;
using AdventOfCode.Lib.Puzzles.Day10;
using AdventOfCode.Lib.Puzzles.Day11;
using AdventOfCode.Lib.Puzzles.Day2;
using AdventOfCode.Lib.Puzzles.Day3;
using AdventOfCode.Lib.Puzzles.Day4;
using AdventOfCode.Lib.Puzzles.Day5;
using AdventOfCode.Lib.Puzzles.Day6;
using AdventOfCode.Lib.Puzzles.Day7;
using AdventOfCode.Lib.Puzzles.Day8;
using AdventOfCode.Lib.Puzzles.Day9;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {

            //SolveDay1();
            //SolveDay2();
            //SolveDay3();
            //SolveDay4();
            //SolveDay5();
            //SolveDay6();
            //SolveDay7();
            //SolveDay9();
            //SolveDay10();
            SolveDay11();
        }
        private static void SolveDay11()
        {
            string[] inputData = new string[]{
                "L.LL.LL.LL",
                "LLLLLLL.LL",
                "L.L.L..L..",
                "LLLL.LL.LL",
                "L.LL.LL.LL",
                "L.LLLLL.LL",
                "..L.L.....",
                "LLLLLLLLLL",
                "L.LLLLLL.L",
                "L.LLLLL.LL"
            };
            //var data = new StringData(inputData);
            var data = new StringData(".\\Data\\Day11a.txt");
            var day = new Day11(data);
            Console.WriteLine("Day11");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void SolveDay10()
        {
            var data = new IntData(".\\Data\\Day10a.txt");
            var day = new Day10(data);
            Console.WriteLine("Day10");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void SolveDay9()
        {
            LongData data = new LongData(".\\Data\\Day9a.txt");
            Day9 day = new Day9(data,25);
            Console.WriteLine("Day9");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void SolveDay8()
        {
            //string[] stringData = new string[]{
            //    "nop +0"
            //    ,"acc +1"
            //    ,"jmp +4"
            //    ,"acc +3"
            //    ,"jmp -3"
            //    ,"acc -99"
            //    ,"acc +1"
            //    ,"jmp -4"
            //    ,"acc +6"
            //};
            //StringData data = new StringData(stringData);
            StringData data = new StringData(".\\Data\\Day8a.txt");
            Day8 day = new Day8(data);
            Console.WriteLine("Day8");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private static void SolveDay7()
        {
            StringData data = new StringData(".\\Data\\Day7a.txt");
            Day7 day = new Day7(data);
            Console.WriteLine("Day7");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private static void SolveDay6()
        {
            StringData data = new StringData(".\\Data\\Day6a.txt");
            Day6 day = new Day6(data);
            Console.WriteLine("Day6");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void SolveDay5()
        {
            StringData data = new StringData(".\\Data\\Day5a.txt");
            Day5 day = new Day5(data);
            Console.WriteLine("Day5");
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
        private static void SolveDay3()
        {
            StringData data = new StringData(".\\Data\\Day3a.txt");
            Day3 day = new Day3(data);
            Console.WriteLine("Day3");
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
        private static void SolveDay1()
        {
            IntData data = new IntData(".\\Data\\Day1a.txt");
            Day1 day = new Day1(data);
            Console.WriteLine("Day1");
            day.SolveToConsole();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
