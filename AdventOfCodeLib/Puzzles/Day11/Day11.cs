using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day11
{
    public class Day11 : DaySolver<string, int>
    {
        bool debug = false;
        public Day11(Data<string> data) : base(data)
        {
        }

        public override int Puzzle1Solution()
        {
            var seats = new SeatBlock(Data.Get());
            if (debug)
            {
                Console.WriteLine("InitialState:");
                Console.WriteLine(seats);
                Console.WriteLine();
            }
            int i = 1;

            while (!seats.InSteadyState())
            {
                seats.AdvanceSimulation();
                if (debug)
                {
                    Console.WriteLine(string.Format("Iteration {0}:", i));
                    Console.WriteLine(seats);
                    Console.WriteLine();
                }
                i++;
            }

            Console.WriteLine("Final state:");
            Console.WriteLine(seats);
            return seats.Seats.Count(s => s.Occupied);
        }

        public override int Puzzle2Solution()
        {
            return 0;
        }
    }
}
