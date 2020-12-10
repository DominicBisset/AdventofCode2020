using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Lib.Helpers;
using AdventOfCode.Lib.Puzzles.Day10;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class TestDay10
    {
        [TestMethod]
        public void TestPartA_Example1()
        {
            int[] inputData = new int[]{
                16
                ,10
                ,15
                ,5
                ,1
                ,11
                ,7
                ,19
                ,6
                ,12
                ,4
            };

            int expectedOutput = 35;

            var data = new IntData(inputData);
            Day10 day = new Day10(data);

            var actualOutut = day.Puzzle1Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartA_Example2()
        {
            int[] inputData = new int[]{
                28
                ,33
                ,18
                ,42
                ,31
                ,14
                ,46
                ,20
                ,48
                ,47
                ,24
                ,23
                ,49
                ,45
                ,19
                ,38
                ,39
                ,11
                ,1
                ,32
                ,25
                ,35
                ,8
                ,17
                ,7
                ,9
                ,4
                ,2
                ,34
                ,10
                ,3
            };

            int expectedOutput = 220;

            var data = new IntData(inputData);
            Day10 day = new Day10(data);

            var actualOutut = day.Puzzle1Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_Example1()
        {
            int[] inputData = new int[]{
                16
                ,10
                ,15
                ,5
                ,1
                ,11
                ,7
                ,19
                ,6
                ,12
                ,4
            };

            int expectedOutput = 8;

            var data = new IntData(inputData);
            Day10 day = new Day10(data);

            var actualOutut = day.Puzzle2Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }

        [TestMethod]
        public void TestPartB_Example2()
        {
            int[] inputData = new int[]{
                28
                ,33
                ,18
                ,42
                ,31
                ,14
                ,46
                ,20
                ,48
                ,47
                ,24
                ,23
                ,49
                ,45
                ,19
                ,38
                ,39
                ,11
                ,1
                ,32
                ,25
                ,35
                ,8
                ,17
                ,7
                ,9
                ,4
                ,2
                ,34
                ,10
                ,3
            };

            int expectedOutput = 19208;

            var data = new IntData(inputData);
            Day10 day = new Day10(data);

            var actualOutut = day.Puzzle2Solution();

            Assert.AreEqual(expectedOutput, actualOutut);
        }

    }
}
