﻿using OpenTK;

namespace Bearded.Utilities.SpaceTime
{
    public struct Position2
    {
        private readonly Unit x;
        private readonly Unit y;

        public Position2(Vector2 p)
            :this(p.X.Units(), p.Y.Units())
        {
            
        }

        public Position2(Unit x, Unit y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 Vector { get { return new Vector2(this.x.NumericValue, this.y.NumericValue); } }

        public Unit X { get { return this.x; } }
        public Unit Y { get { return this.y; } }


        public static Difference2 operator -(Position2 p0, Position2 p1)
        {
            return new Difference2(p0.x - p1.x, p0.y - p1.y);
        }

        public static Position2 operator +(Position2 p, Difference2 d)
        {
            return new Position2(p.x + d.X, p.y + d.Y);
        }
    }
}
