using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day3
{
    public class SlopeSegment
    {
        
        public Cell this[int index]
        {
            get { return cells[index % cells.Length]; } 
        }

        private string segementDefintion;
        private Cell[] cells;

        public SlopeSegment(string segementDefintion)
        {
            this.segementDefintion = segementDefintion;
            cells = segementDefintion.Select(d => new Cell(d)).ToArray();
        }

    }
}
