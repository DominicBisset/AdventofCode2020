using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Helpers;
using AdventOfCode.Lib.Puzzles.Day11;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay11
    {
        [TestMethod]
        public void TestPartA_Example1()
        {
            string[] inputData = new string[]{
                "L.LL.LL.LL",
                "LLLLLLL.LL",
                "L.L.L..L..",
                "LLLL.LL.LL",
                "L.LL.LL.LL",
                "L.LLLLL.LL",
                "..L.L.....",
                "LLLLLLLLLL",
                "L.LLLLLL.L",
                "L.LLLLL.LL"
            };

            int expectedOutput = 37;

            var data = new StringData(inputData);
            Day11 day = new Day11(data);

            var actualOutut = day.Puzzle1Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }


        [TestMethod]
        public void TestPartB_Example1()
        {
            string[] inputData = new string[]{
                "L.LL.LL.LL",
                "LLLLLLL.LL",
                "L.L.L..L..",
                "LLLL.LL.LL",
                "L.LL.LL.LL",
                "L.LLLLL.LL",
                "..L.L.....",
                "LLLLLLLLLL",
                "L.LLLLLL.L",
                "L.LLLLL.LL"
            };

            int expectedOutput = 26;

            var data = new StringData(inputData);
            Day11 day = new Day11(data);

            var actualOutut = day.Puzzle2Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }

    }
}
