using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Helpers
{
    public abstract class DaySolver<SourceDataType, OutputDataType>
    {
        internal Data<SourceDataType> Data { get; }
        public DaySolver(Data<SourceDataType> data)
        {
            Data = data;
        }

        public abstract OutputDataType Puzzle1Solution();
        public abstract OutputDataType Puzzle2Solution();

        public void SolveToConsole()
        {
            var output = Puzzle1Solution();
            Console.WriteLine(output);

            output = Puzzle2Solution();
            Console.WriteLine(output);
        }


    }
}
