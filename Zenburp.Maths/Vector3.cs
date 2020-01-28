using System;
using System.Collections.Generic;
using System.Text;

namespace Zenburp.Maths
{
    public readonly struct Vector3
    {
        public readonly Single x;
        public readonly Single y;
        public readonly Single z;

        public Vector2 xy
        {
            get { return new Vector2(x, y); }
        }

        public Vector3(Single x, Single y, Single z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool Equals(Vector3 a)
        {
            return (
                this.x.Equals(a.x) &&
                this.y.Equals(a.y) &&
                this.z.Equals(a.z)
            );
        }

        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return (a.Equals(b));
        }

        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return (!a.Equals(b));
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return Vector.Add(a, b);
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return Vector.Subtract(a, b);
        }

        public static Vector3 operator *(Vector3 a, Single b)
        {
            return Vector.Multiply(a, b);
        }
    }
}
