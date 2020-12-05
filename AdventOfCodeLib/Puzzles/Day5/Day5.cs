using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day5
{
    public class Day5 : DaySolver<string, int>
    {
        public Day5(Data<string> data) : base(data)
        {
        }

        public override int Puzzle1Solution()
        {
            return Data.Get()
                .Select(s => new BoardingPass(s))
                .Max(bp => bp.SeatID())
                ;
        }

        public override int Puzzle2Solution()
        {
            var ordered = Data.Get()
                .Select(s => new BoardingPass(s))
                .OrderBy(bp => bp.SeatID())
                .ToArray();

            for (int i=0; i<ordered.Count() - 1; i++)
            {
                int nextExpectedSeat = ordered[i].SeatID() + 1;
                int actualNextSeatId = ordered[i + 1].SeatID();
                if (nextExpectedSeat != actualNextSeatId)
                {
                    return nextExpectedSeat;
                }
            }
            throw new Exception("Seat Not Found");
        }
    }
}
