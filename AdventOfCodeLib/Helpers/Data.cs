using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode.Lib.Helpers
{
    public abstract class Data<T>
    {
        internal string[] stringData;
        internal List<T> parsedData;

        public Data(string filename)
        {
            stringData = File.ReadAllLines(filename);
            parsedData = Parse();
        }

        internal void TakeWhile()
        {
            throw new NotImplementedException();
        }

        public Data(string[] sourceStrings)
        {
            stringData = sourceStrings;
            parsedData = Parse();
        }

        public Data(T[] sourceT)
        {
            stringData = sourceT.Select(t => t.ToString()).ToArray();
            parsedData = new List<T>(sourceT);
        }

        internal abstract List<T> Parse();

        public List<T> Get()
        {
            return parsedData;
        }
    }
}
