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
        public void TestPartB()
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
    }
}
