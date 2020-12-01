using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib
{
    public class Day1
    {
        const int Target = 2020;

        public int ExpensesAmount1A (ICollection<int> numbers)
        {
            var pair = PairSummingTo2020(new List<int>(numbers));
            return pair.Item1 * pair.Item2;
        }
        public int ExpensesAmount1B(ICollection<int> numbers)
        {
            var triplet = TripletSummingTo2020(new List<int>(numbers));
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

        //Tuple<int,int> NumbersSummingTo2020(List<int> numbers)
        //{
        //    List<int> numbersCopy = numbers;
        //    numbersCopy.Sort();
        //    int p1 = 0;
        //    int p2 = numbers.Count;
        //    int smallerNumberLowerBound = p1;
        //    int smallerNumberUpperBound = p2;
        //    int largerNumberLowerBound = p1;
        //    int largerNumberUpperBound = p2;
        //    int pivot = numbers.Count / 2;


        //    int smallerNumber = numbers[p1];
        //    int biggerNumber = numbers[p2];
        //    int pivotNumber = numbers[pivot];

        //    if (smallerNumber + pivotNumber > Target)
        //    {
        //        p2 = pivot;
        //        biggerNumber = pivotNumber;
        //    }
        //    else if (pivotNumber + biggerNumber < Target)
        //    {
        //        p1 = pivot;
        //        smallerNumber = pivotNumber;
        //    }
        //    else
        //    while(p1<p2)
        //    {

        //        while (smallerNumber + biggerNumber > Target)
        //        {
        //            p2--;
        //            biggerNumber = numbers[p2];
        //        }
        //        if (smallerNumber + biggerNumber == Target)
        //        {
        //            return (smallerNumber, biggerNumber).ToTuple<int,int>();
        //        }
        //        p1++;
        //        while (smallerNumber + biggerNumber < Target)
        //        {
        //            p2++;
        //            biggerNumber = numbers[p2];
        //        }
        //        if (smallerNumber + biggerNumber == Target)
        //        {
        //            return (smallerNumber, biggerNumber).ToTuple<int, int>();
        //        }


        //    }
        //    throw new Exception("No pairings found that sum to target");
        //}
    }
}
