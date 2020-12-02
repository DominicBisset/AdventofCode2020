using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Puzzles.Day2;
using AdventOfCode.Lib.Helpers;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay2
    {
        [TestMethod]
        public void TestDay2A()
        {
            string[] passwordAndPolicyStrings = new string[] { 
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };
            var data = new StringData(passwordAndPolicyStrings);
            int expectedOutput = 2;
            Day2 day2 = new Day2(data);

            var actualOutut = day2.Puzzle1Solution();


            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestDay2B()
        {
            string[] passwordAndPolicyStrings = new string[] {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };
            var data = new StringData(passwordAndPolicyStrings);
            int expectedOutput = 1;
            Day2 day2 = new Day2(data);

            var actualOutut = day2.Puzzle2Solution();


            Assert.AreEqual(expectedOutput, actualOutut);
        }
    }
}
