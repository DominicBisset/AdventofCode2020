using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Helpers;
using AdventOfCode.Lib.Puzzles.Day9;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay9
    {
        [TestMethod]
        public void TestPartA()
        {
            long[] inputData = new long[]{
                35
                ,20
                ,15
                ,25
                ,47
                ,40
                ,62
                ,55
                ,65
                ,95
                ,102
                ,117
                ,150
                ,182
                ,127
                ,219
                ,299
                ,277
                ,309
                ,576
            };
            int preambleLength = 5;
            int expectedOutput = 127;

            var data = new LongData(inputData);
            Day9 day = new Day9(data, preambleLength);

            var actualOutut = day.Puzzle1Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB()
        {
            long[] inputData = new long[]{
                35
                ,20
                ,15
                ,25
                ,47
                ,40
                ,62
                ,55
                ,65
                ,95
                ,102
                ,117
                ,150
                ,182
                ,127
                ,219
                ,299
                ,277
                ,309
                ,576
            };
            int preambleLength = 5;
            int expectedOutput = 62;

            var data = new LongData(inputData);
            Day9 day = new Day9(data, preambleLength);

            var actualOutut = day.Puzzle2Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }

    }
}
