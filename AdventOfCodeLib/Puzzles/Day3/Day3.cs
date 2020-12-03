using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day3
{
    public class Day3 : DaySolver<string, int>
    {
        public Day3(Data<string> data) : base(data)
        {
        }

        public override int Puzzle1Solution()
        {
            Slope slope = new Slope(Data.Get());
            Heading heading = new Heading(3, 1);
            return TreeCount(slope, heading);
        }

        private int TreeCount(Slope slope, Heading heading)
        {
            var treeCounter = 0;
            int col = 0;

            for (int row = 0; row < slope.Segments.Length; row += heading.Down)
            {
                treeCounter += slope.Segments[row][col].Cost;
                col += heading.Right;
            }
            return treeCounter;
        }

        public override int Puzzle2Solution()
        {
            Heading[] headings = new Heading[]
            {
                new Heading(1,1),
                new Heading(3,1),
                new Heading(5,1),
                new Heading(7,1),
                new Heading(1,2)
            };

            Slope slope = new Slope(Data.Get());
            return headings.Select(heading => TreeCount(slope, heading))
                .Aggregate(1, (accumulator, newVal) => accumulator * newVal);
        }
    }
}
