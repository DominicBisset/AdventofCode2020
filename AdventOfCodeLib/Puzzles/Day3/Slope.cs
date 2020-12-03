using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day3
{
    public class Slope
    {
        public SlopeSegment[] Segments { get; }

        public Slope(IEnumerable<string> SlopeDefintion)
        {
            Segments = SlopeDefintion.Select(d => new SlopeSegment(d)).ToArray();
        }
    }
}
