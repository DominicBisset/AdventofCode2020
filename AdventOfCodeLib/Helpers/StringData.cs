using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Helpers
{
    public class StringData : Data<string>
    {
        public StringData(string filename) : base(filename)
        {
        }

        public StringData(string[] sourceStrings) : base(sourceStrings)
        {
        }

        internal override List<string> Parse()
        {
            return new List<string>(stringData);
        }
    }
}
