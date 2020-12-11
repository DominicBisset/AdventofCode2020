using System.Text;

namespace AdventOfCode.Lib.Helpers
{
    public class Coordinates
    {
        public int X { get; }
        public int Y { get; }
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinates Add(Heading heading)
        {
            return new Coordinates(X + heading.Right, Y + heading.Down);
        }
        public Coordinates Add(Heading heading, int multiple)
        {
            return new Coordinates(X + (multiple * heading.Right), Y + (multiple * heading.Down));
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("(");
            sb.Append(X);
            sb.Append(",");
            sb.Append(Y);
            sb.Append(")");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Coordinates coords = obj as Coordinates;
            if (coords !=null)
            {
                return coords.X == X && coords.Y == Y;
            }
            else {
                return base.Equals(obj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}