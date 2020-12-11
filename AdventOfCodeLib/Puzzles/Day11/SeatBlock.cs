using AdventOfCode.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Lib.Puzzles.Day11
{
    public class SeatBlock
    {
        public List<Seat> Seats = new List<Seat>();
        public Dictionary<Coordinates,Seat> TrueSeatsDictionary = new Dictionary<Coordinates,Seat>();

        public SeatBlock(IEnumerable<string> defintion)
        {
            for(int y = 0; y < defintion.Count(); y++)
            {
                string seatRow = defintion.ElementAt(y);
                for (int x = 0; x < seatRow.Length; x++)
                {
                    Seat s = new Seat(this, new Coordinates(x, y), seatRow[x], 4);
                    Seats.Add(s);
                    if (!s.IsNull)
                    {
                        TrueSeatsDictionary.Add(s.Location, s);
                    }
                }
            }

            foreach (Seat seat in Seats)
            {
                seat.PrepareNextSimulationStep();
            }
        }

        internal List<Seat> GetNeighbours(Coordinates location)
        {
            return Seats.Where(s => !s.IsNull)
                    .Where(s =>
                    //In column to left
                    (s.Location.X == location.X - 1 && s.Location.Y >= location.Y - 1 && s.Location.Y <= location.Y + 1)
                    ||
                    //Above or below
                    (s.Location.X == location.X && (s.Location.Y == location.Y - 1 || s.Location.Y == location.Y + 1))
                    ||
                    //Column to right
                    (s.Location.X == location.X + 1 && s.Location.Y >= location.Y - 1 && s.Location.Y <= location.Y + 1)

                ).ToList();
        }


        internal List<Seat> GetDistantNeighbours(Coordinates location)
        {
            Heading[] headings = new Heading[]
            {
                new Heading(-1,-1),
                new Heading(0,-1),
                new Heading(1,-1),
                new Heading(-1,0),
                new Heading(1,0),
                new Heading(-1,1),
                new Heading(0,1),
                new Heading(1,1)

            };

            List<Seat> neighbours = new List<Seat>();

            foreach(Heading h in headings)
            {
                bool found = false;
                int projectionDistance = 0;
                while(!found)
                {
                    projectionDistance++;
                    var nextLoc = location.Add(h, projectionDistance);
                    found = TrueSeatsDictionary.TryGetValue(nextLoc, out Seat seat);
                    if (found)
                    {
                        neighbours.Add(seat);
                    }
                }
            }

            return Seats.Where(s => !s.IsNull)
                    .Where(s =>
                    //In column to left
                    (s.Location.X == location.X - 1 && s.Location.Y >= location.Y - 1 && s.Location.Y <= location.Y + 1)
                    ||
                    //Above or below
                    (s.Location.X == location.X && (s.Location.Y == location.Y - 1 || s.Location.Y == location.Y + 1))
                    ||
                    //Column to right
                    (s.Location.X == location.X + 1 && s.Location.Y >= location.Y - 1 && s.Location.Y <= location.Y + 1)

                ).ToList();
        }

        public void AdvanceSimulation()
        {
            foreach (Seat seat in Seats)
            {
                seat.AdvanceSimulation();
            }
            foreach (Seat seat in Seats)
            {
                seat.PrepareNextSimulationStep();
            }
        }

        public bool InSteadyState()
        {
            return Seats.All(s => s.InSteadyState());
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            int currentRow = 0;
            foreach(Seat s in Seats)
            {
                if (s.Location.Y != currentRow)
                {
                    sb.AppendLine();
                    currentRow = s.Location.Y;
                }
                sb.Append(s);
            }
            return sb.ToString();
        }
    }
}
