using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Helpers
{
    public class LongData : Data<long>
    {
        public LongData(string filename) : base(filename)
        {
        }

        public LongData(string[] sourceStrings) : base(sourceStrings)
        {
        }

        public LongData(long[] sourcelongs) : base(sourcelongs)
        {
        }

        internal override List<long> Parse()
        {
            List<long> longs = new List<long>();
            foreach (string line in stringData)
            {
                longs.Add(long.Parse(line));
            }
            return longs;
        }
    
    }
}
