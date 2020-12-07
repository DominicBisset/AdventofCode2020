using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Puzzles.Day4;
using AdventOfCode.Lib.Helpers;
using System.Numerics;
using System;
using AdventOfCode.Lib.Puzzles.Day6;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay6
    {
        [TestMethod]
        public void TestPartA()
        {
            string[] inputData = new string[]{
                "abc",
                "",
                "a",
                "b",
                "c",
                "",
                "ab",
                "ac",
                "",
                "a",
                "a",
                "a",
                "a",
                "",
                "b"
            };
            int expectedOutput = 11;

            var data = new StringData(inputData);
            Day6 day = new Day6(data);

            var actualOutut = day.Puzzle1Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }
        [TestMethod]
        public void TestPartB()
        {
            string[] inputData = new string[]{
                "abc",
                "",
                "a",
                "b",
                "c",
                "",
                "ab",
                "ac",
                "",
                "a",
                "a",
                "a",
                "a",
                "",
                "b"
            };
            int expectedOutput = 6;

            var data = new StringData(inputData);
            Day6 day = new Day6(data);

            var actualOutut = day.Puzzle2Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }
    }
}
