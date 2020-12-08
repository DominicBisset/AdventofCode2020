using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Helpers;
using AdventOfCode.Lib.Puzzles.Day8;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay8
    {
        [TestMethod]
        public void TestPartA()
        {
            string[] inputData = new string[]{
                "nop +0"
                ,"acc +1"
                ,"jmp +4"
                ,"acc +3"
                ,"jmp -3"
                ,"acc -99"
                ,"acc +1"
                ,"jmp -4"
                ,"acc +6"
            };
            int expectedOutput = 5;

            var data = new StringData(inputData);
            Day8 day = new Day8(data);

            var actualOutut = day.Puzzle1Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_Example1()
        {
            string[] inputData = new string[]{
                "nop +0"
                ,"acc +1"
                ,"jmp +4"
                ,"acc +3"
                ,"jmp -3"
                ,"acc -99"
                ,"acc +1"
                ,"jmp -4"
                ,"acc +6"
            };
            int expectedOutput = 8;

            var data = new StringData(inputData);
            Day8 day = new Day8(data);

            var actualOutut = day.Puzzle2Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_Example2()
        {
            string[] inputData = new string[]{
                "shiny gold bags contain 2 dark red bags.",
                "dark red bags contain 2 dark orange bags.",
                "dark orange bags contain 2 dark yellow bags.",
                "dark yellow bags contain 2 dark green bags.",
                "dark green bags contain 2 dark blue bags.",
                "dark blue bags contain 2 dark violet bags.",
                "dark violet bags contain no other bags."
            };
            int expectedOutput = 126;

            var data = new StringData(inputData);
            Day8 day = new Day8(data);

            var actualOutut = day.Puzzle2Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }
    }
}
