using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Lib.Puzzles.Day1
{
    public class Day1 : DaySolver<int, int>
    {
        const int Target = 2020;

        public Day1(Data<int> data) : base(data)
        {
        }
        public override int Puzzle1Solution()
        {
            var pair = PairSummingTo2020(Data.Get());
            return pair.Item1 * pair.Item2;
        }

        public override int Puzzle2Solution()
        {
            var triplet = TripletSummingTo2020(Data.Get());
            Console.WriteLine(triplet);
            return triplet.Item1 * triplet.Item2 * triplet.Item3;
        }

        Tuple<int, int> PairSummingTo2020(List<int> numbers)
        {
            List<int> numbersCopy = numbers;
            numbersCopy.Sort();

            foreach (int smallerNumber in numbersCopy)
            {
                int topPointer = numbersCopy.Count - 1;
                int biggerNumber = numbers[topPointer];
                while (smallerNumber + biggerNumber >= Target)
                {
                    if (smallerNumber + biggerNumber == Target)
                    {
                        return (smallerNumber, biggerNumber).ToTuple<int, int>();
                    }
                    topPointer--;
                    biggerNumber = numbers[topPointer];
                }
            }

            throw new Exception("No pairings found that sum to target");
        }
        Tuple<int, int, int> TripletSummingTo2020(List<int> numbers)
        {
            List<int> numbersCopy = numbers;
            numbersCopy.Sort();
            foreach (int smallerNumber in numbersCopy)
            {
                int topPointer = numbersCopy.Count - 1;
                int biggerNumber = numbersCopy[topPointer];

                while (biggerNumber > smallerNumber)
                {
                    int middleNumber = (Target - biggerNumber) - smallerNumber;
                    if (numbersCopy.Contains(middleNumber))
                    {
                        return (smallerNumber, middleNumber, biggerNumber).ToTuple<int, int, int>();
                    }
                    topPointer--;
                    biggerNumber = numbersCopy[topPointer];
                }
            }

            throw new Exception("No pairings found that sum to target");
        }

    }
}
