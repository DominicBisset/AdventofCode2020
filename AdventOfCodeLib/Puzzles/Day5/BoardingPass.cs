using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day5
{
    public class BoardingPass
    {
        string SeatReference { get; }

        public int RowNumber { get; }
        public int ColumnNumber { get; }

        public BoardingPass(string seatReference)
        {
            SeatReference = seatReference;
            RowNumber = GetRowNumber();
            ColumnNumber = GetColNumber();
        }

        private int GetRowNumber()
        {
            string binaryRowNumber = SeatReference.Substring(0, 7)
                    .Replace('B', '1')
                    .Replace('F', '0');
            return Convert.ToInt32(binaryRowNumber, 2);
        }
        private int GetColNumber()
        {
            string binaryColNumber = SeatReference.Substring(7,3)
                    .Replace('R', '1')
                    .Replace('L', '0');
            return Convert.ToInt32(binaryColNumber, 2);
        }

        public int SeatID()
        {
            return (RowNumber * 8 ) + ColumnNumber;
        }
    }
}
