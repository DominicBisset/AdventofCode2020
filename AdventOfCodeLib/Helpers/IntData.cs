using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Helpers
{
    public class IntData : Data<int>
    {
        public IntData(string filename) : base(filename)
        {
        }

        public IntData(string[] sourceStrings) : base(sourceStrings)
        {
        }

        public IntData(int[] sourceInts) : base(sourceInts)
        {
        }

        internal override List<int> Parse()
        {
            List<int> ints = new List<int>();
            foreach (string line in stringData)
            {
                ints.Add(int.Parse(line));
            }
            return ints;
        }
    
    }
}
