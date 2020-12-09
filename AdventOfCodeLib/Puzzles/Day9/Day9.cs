using AdventOfCode.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Lib.Puzzles.Day9

{
    public class Day9 : DaySolver<long, long>
    {
        private int PreambleLength;

        public Day9(Data<long> data, int preambleLength) : base(data)
        {
            PreambleLength = preambleLength;
        }

        public override long Puzzle1Solution()
        {
            var dataStream = Data.Get();
            int end = dataStream.Count - PreambleLength;
            for(int start=0; start<end; start++)
            {
                var newPreamble = dataStream.Skip(start).Take(PreambleLength);
                var target = dataStream.Skip(start+PreambleLength).First();
                var pair = PairSummingToTarget(newPreamble, target);

                if (pair == null)
                { 
                    return target;
                }
            }

            throw new Exception("All values meet protocol");
        }


        Tuple<long, long> PairSummingToTarget(IEnumerable<long> numbers, long Target)
        {
            List<long> numbersCopy = numbers.ToList();
            numbersCopy.Sort();

            for(int bottomPointer = 0; bottomPointer < numbersCopy.Count -1; bottomPointer ++)
            {
                long smallerNumber = numbersCopy.Skip(bottomPointer).First();
                int topPointer = numbersCopy.Count - 1;
                long biggerNumber = numbersCopy.Skip(topPointer).First();
                while (smallerNumber + biggerNumber >= Target && topPointer > bottomPointer)
                {
                    if (smallerNumber + biggerNumber == Target)
                    {
                        return (smallerNumber, biggerNumber).ToTuple<long, long>();
                    }
                    topPointer--;
                    biggerNumber = numbersCopy.Skip(topPointer).First();
                }

            }

            return null;
        }

        public override long Puzzle2Solution()
        {
            long target = Puzzle1Solution();
            var allNumbers = Data.Get();
            List<long> numbers = NumbersSummingToTarget(allNumbers, target);
            return numbers.Min() + numbers.Max() ;
        }

        List<long> NumbersSummingToTarget(IEnumerable<long> numbers, long target)
        {
            for(int lowerPointer = 0; numbers.Skip(lowerPointer).First() < target; lowerPointer++)
            {
                long total = 0;
                for (int subSequenceLength = 2; total < target; subSequenceLength++)
                {
                    IEnumerable<long> range = numbers.Skip(lowerPointer)
                                .Take(subSequenceLength);
                    total = range.Sum();
                    if (total == target)
                    {
                        return range.ToList();
                    }
                }
                
            }

            throw new Exception("Failed to find set of numbers summing to target");
        }
    }
}
