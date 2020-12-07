using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day6
{
    public class Day6 : DaySolver<string, int>
    {
        public Day6(Data<string> data) : base(data)
        {
        }

        public override int Puzzle1Solution()
        {
            var data = Data.Get();

            int skip = 0;
            int len = data.Count();

            int sum = 0;

            while (skip < len)
            {
                var groupLines = data
                    .Skip(skip)
                    .TakeWhile(s => s.Length > 0);
                skip += (groupLines.Count() + 1);
                sum += new Group(groupLines).DistinctQuestions().Count();
            }
            return sum;
        }

        public override int Puzzle2Solution()
        {
            var data = Data.Get();

            int skip = 0;
            int len = data.Count();

            int sum = 0;

            while (skip < len)
            {
                var groupLines = data
                    .Skip(skip)
                    .TakeWhile(s => s.Length > 0);
                skip += (groupLines.Count() + 1);
                sum += new Group(groupLines).CommonQuestions().Count();
            }
            return sum;
        }
    }
}
