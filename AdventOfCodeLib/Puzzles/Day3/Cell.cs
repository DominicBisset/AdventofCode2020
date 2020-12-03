using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day3
{
    public class Cell
    {
        private char definition;

        public int Cost
        {
            get
            {
                return definition switch
                {
                    '.' => 0,
                    '#' => 1,
                    _ => throw new Exception("Cell type doesn't exist"),
                };
            }
        }
            


        public Cell(char definition)
        {
            this.definition = definition;
        }



    }
}
