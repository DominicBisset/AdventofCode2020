using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode.Lib
{
    public class Data
    {
        string[] fileData;
        public Data(string filename)
        {
            fileData = File.ReadAllLines(filename);
        }

        public List<int> AsListOfInts()
        {
            List<int> output = new List<int>();
            foreach(string line in fileData)
            {
                output.Add(int.Parse(line));
            }

            return output;
        }
        public List<string> AsListOfStrings()
        {
            return new List<string>(fileData);
        }


    }
}
