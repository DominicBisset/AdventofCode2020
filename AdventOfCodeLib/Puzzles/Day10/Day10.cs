using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day10
{
    public class Day10 : DaySolver<int, long>
    {
        public Day10(Data<int> data) : base(data)
        {
        }

        public override long Puzzle1Solution()
        {
            List<int> jolts = PrepareJoltList();

            var Differences = new Dictionary<int, int>();
            for (int i = 0; i < jolts.Count - 1; i++)
            {
                int nextDifference = jolts[i + 1] - jolts[i];
                Differences.TryGetValue(nextDifference, out int count);
                Differences[nextDifference] = ++count;

            }
            return Differences[1] * Differences[3];
        }

        private List<int> PrepareJoltList()
        {
            var jolts = Data.Get();
            jolts.Add(0);
            jolts.Sort();
            jolts.Add(jolts.Last() + 3);
            return jolts;
        }



        public override long Puzzle2Solution()
        {
            var jolts = PrepareJoltList();



            //adaptorArrangements = new Dictionary<Tuple<int, int>, long>();
            //return adaptorArrangementsCount(jolts);
            return 0;

        }


        //private long adaptorArrangementsCount(List<int> sortedJolts)
        //{
        //    var current = sortedJolts.First();
        //        .TakeWhile()
        //}
    }
}
