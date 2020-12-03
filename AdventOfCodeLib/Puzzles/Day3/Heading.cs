using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day3
{
    public class Heading
    {
        public int Right { get; }
        public int Down { get; }

        public Heading(int right, int down)
        {
            Right = right;
            Down = down;
        }
    }
}
