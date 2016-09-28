using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return "X= " + X + " Y= " + Y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Point p = obj as Point;
            if ((Object)p == null)
            {
                return false;
            }

            return (X == p.X) && (Y == p.Y);
        }

        public bool Equals(Point p)
        {
            if ((object)p == null)
            {
                return false;
            }

            return (X == p.X) && (Y == p.Y);
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }
    }
}
