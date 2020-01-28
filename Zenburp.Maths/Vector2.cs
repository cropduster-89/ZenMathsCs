using System;
using System.Collections.Generic;
using System.Text;

namespace Zenburp.Maths
{
    public readonly struct Vector2
    {
        public readonly Single x;
        public readonly Single y;

        public Vector2(Single x, Single y)
        {
            this.x = x;
            this.y = y;
        }

        public bool Equals(Vector2 a)
        {
            return (
                this.x.Equals(a.x) &&
                this.y.Equals(a.y)
            );
        }

        public static bool operator ==(Vector2 a, Vector2 b)
        {
            return (a.Equals(b));
        }

        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return (!a.Equals(b));
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return Vector.Add(a, b);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return Vector.Subtract(a, b);
        }

        public static Vector2 operator *(Vector2 a, Single b)
        {
            return Vector.Multiply(a, b);
        }
    }
}
