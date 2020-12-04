using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib;
using AdventOfCode.Lib.Puzzles.Day1;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay1
    {
        [TestMethod]
        public void TestPartA()
        {
            int[] numbers = new int[] { 1721, 979, 366, 299, 675, 1456};
            var data = new IntData(numbers);
            int expectedOutput = 514579;
            Day1 day1 = new Day1(data);

            var actualOutut = day1.Puzzle1Solution();


            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB()
        {
            int[] numbers = new int[] { 1721, 979, 366, 299, 675, 1456 };
            var data = new IntData(numbers);
            int expectedOutput = 241861950;
            Day1 day1 = new Day1(data);

            var actualOutut = day1.Puzzle2Solution();


            Assert.AreEqual(expectedOutput, actualOutut);
        }
    }
}
