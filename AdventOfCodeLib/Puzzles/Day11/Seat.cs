using AdventOfCode.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Lib.Puzzles.Day11
{
    public class Seat
    {
        public bool Occupied { get; set; }
        public bool IsNull { get; }
        public Coordinates Location { get; }
        public char SeatLabel { get; }
        private SeatBlock Parent {get ;}

        private const char NullChar = '.';
        private const char AvailableChar = 'L';
        private const char OccupiedChar = '#';
        private int OvercrowdingThreshold;

        private List<Seat> _neighbours = null;
        private bool nextOccupied;
        //Prevent simulation advancing while neighbours might still be preparing thier next state
        private bool ReadyToAdvance = false;
        private bool PreparedOnce;

        private List<Seat> Neighbours { get
            {
                if (_neighbours == null)
                {
                    _neighbours = Parent.GetNeighbours(Location);
                }
                return _neighbours;
            }
        }

        public override string ToString()
        {
            if (IsNull)
            {
                return NullChar.ToString();
            }
            else
            {
                return (Occupied ? OccupiedChar : AvailableChar).ToString();
            }

        }
        public Seat(SeatBlock parent, Coordinates location, char s, int overcrowdingThreshold)
        {
            SeatLabel = s;
            OvercrowdingThreshold = overcrowdingThreshold;
            Parent = parent;
            Location = location;
            switch (s)
            {
                case NullChar:
                    IsNull = true;
                    Occupied = false;
                    break;
                case AvailableChar:
                    Occupied = false;
                    IsNull = false;
                    break;
                case OccupiedChar:
                    Occupied = true;
                    IsNull = false;
                    break;
            }
        }

        internal void PrepareNextSimulationStep()
        {
            if(IsNull)
            {
                return;
            }

            //Default to no-change
            nextOccupied = Occupied;
            if (!Occupied && Neighbours.TrueForAll(s => !s.Occupied))
            {
                nextOccupied = true;
            }
            else if (Occupied && Neighbours.Count(s => s.Occupied) >= OvercrowdingThreshold)
            {
                nextOccupied = false;
            }
            ReadyToAdvance = true;
            PreparedOnce = true;
        }

        internal void AdvanceSimulation()
        {
            if (IsNull)
            {
                return;
            }

            if (!ReadyToAdvance)
            {
                throw new Exception("Tried to advance sim before prepping next step");
            }
            Occupied = nextOccupied;
            ReadyToAdvance = false;
        }

        public bool InSteadyState()
        {
            if (IsNull)
            {
                return true;
            }
            //Only return true if the next state has been calculated at least once
            return PreparedOnce && nextOccupied == Occupied;
        }

    }
}