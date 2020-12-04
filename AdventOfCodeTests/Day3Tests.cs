using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Puzzles.Day3;
using AdventOfCode.Lib.Helpers;
using System.Numerics;
using System;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay3
    {
        [TestMethod]
        public void TestPartA()
        {
            string[] slopeDefinition = new string[] {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };
            var data = new StringData(slopeDefinition);
            int expectedOutput = 7;
            Day3 day3 = new Day3(data);

            var actualOutut = day3.Puzzle1Solution();


            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB()
        {
            string[] slopeDefinition = new string[] {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };
            var data = new StringData(slopeDefinition);
            int expectedOutput = 336;
            Day3 day3 = new Day3(data);

            var actualOutut = day3.Puzzle2Solution();


            Assert.AreEqual(expectedOutput, actualOutut);


            Assert.AreEqual(expectedOutput, actualOutut);
        }
    }
}
