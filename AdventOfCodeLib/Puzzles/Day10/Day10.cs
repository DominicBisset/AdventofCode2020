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

        private int maxJoltageChange = 3;

        private List<int> PrepareJoltList()
        {
            var jolts = Data.Get();
            jolts.Add(0);
            jolts.Sort();
            jolts.Add(jolts.Last() + maxJoltageChange);
            return jolts;
        }



        public override long Puzzle2Solution()
        {
            var jolts = PrepareJoltList();
            var posibleOnwardConnections = new List<int>();
            for(int i = 0 ; i < jolts.Count; i++)
            {
                int currentJolts = jolts[i];
                int currentPossibleOnwardConnections = 0;
                for(int j = 1; j <= maxJoltageChange && i + j < jolts.Count() ; j++)
                {
                    if (jolts[i + j] <= currentJolts + maxJoltageChange)
                    {
                        currentPossibleOnwardConnections++;
                    }
                    else
                    {
                        break;
                    }
                }
                posibleOnwardConnections.Add(currentPossibleOnwardConnections);
            }

            var posiblePreviousConnections = new List<int>();

            for (int i = jolts.Count -1; i >= 0; i--)
            {
                int currentJolts = jolts[i];
                int currentPosiblePreviousConnections = 0;
                for (int j = 1; j < maxJoltageChange && i - j >= 0; j++)
                {
                    if (jolts[i - j] >= currentJolts - maxJoltageChange)
                    {
                        currentPosiblePreviousConnections++;
                    }
                    else
                    {
                        break;
                    }
                }
                posiblePreviousConnections.Add(currentPosiblePreviousConnections);
            }

            posiblePreviousConnections.Reverse();

            List<List<int>> subgroups = new List<List<int>>();
            int subGroupStart = 0;
            int subGroupEnd = 0;

            while (subGroupEnd < jolts.Count)
            {

                for (int i = subGroupStart; i < jolts.Count - 1; i++)
                {
                    if(posibleOnwardConnections[i] == 1 && posiblePreviousConnections[i+1] == 1)
                    {
                        subGroupEnd = i;
                        break;
                    }
                }
                subgroups.Add(jolts
                    .Skip(subGroupStart)
                    .Take(1 + subGroupEnd - subGroupStart)
                    .ToList()
                ) ;
                subGroupStart = subGroupEnd  + 1;
                subGroupEnd = subGroupStart;
            }


            var subgroupArrangements = subgroups.Select(sg => adaptorSubGroupArrangementsCount(sg));
            var connectionOptions = subgroupArrangements.Aggregate((agg, c) => agg * c);

            return connectionOptions;

        }


        private long adaptorSubGroupArrangementsCount(List<int> sortedJoltsSubGroup)
        {
            if(sortedJoltsSubGroup.Count() < 3)
            {
                return 1;
            }

            long connectionOptions = 1;
            for(int i = 0; i < sortedJoltsSubGroup.Count - 1; i++)
            {
                int jolt = sortedJoltsSubGroup[i];
                connectionOptions += sortedJoltsSubGroup
                        .Skip(i + 1)
                        .Take(maxJoltageChange)
                        .Count(jNext => jNext <= jolt + maxJoltageChange)
                        - 1;
            }
            return connectionOptions;
        }
    }
}
