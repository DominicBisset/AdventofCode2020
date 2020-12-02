using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day2
{
    public class Day2 : DaySolver<string, int>
    {
        public Day2(Data<string> data) : base(data)
        {
        }

        public override int Puzzle1Solution()
        {
            var parsed = Data.Get()
                            .Select(pps => new PolicyAndPasswordString2A(pps));
            return parsed.Count(pps => pps.IsValid());
        }

        public override int Puzzle2Solution()
        {
            var parsed = Data.Get()
                            .Select(pps => new PolicyAndPasswordString2B(pps));
            return parsed.Count(pps => pps.IsValid());
        }
    }
}
