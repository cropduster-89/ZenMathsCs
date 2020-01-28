using System;
using System.Collections.Generic;
using System.Text;

namespace Zenburp.Maths
{
    public readonly struct Vector4
    {
        public readonly Single x;
        public readonly Single y;
        public readonly Single z;
        public readonly Single w;

        public Vector3 xyz
        {
            get { return new Vector3(x, y, z); }
        }

        public Vector4(Single x, Single y, Single z, Single w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public bool Equals(Vector4 a)
        {
            return (
                this.x.Equals(a.x) &&
                this.y.Equals(a.y) &&
                this.z.Equals(a.z) &&
                this.w.Equals(a.w)
            );
        }

        public static bool operator ==(Vector4 a, Vector4 b)
        {
            return (a.Equals(b));
        }

        public static bool operator !=(Vector4 a, Vector4 b)
        {
            return (!a.Equals(b));
        }

        public static Vector4 operator +(Vector4 a, Vector4 b)
        {
            return Vector.Add(a, b);
        }

        public static Vector4 operator -(Vector4 a, Vector4 b)
        {
            return Vector.Subtract(a, b);
        }

        public static Vector4 operator *(Vector4 a, Single b)
        {
            return Vector.Multiply(a, b);
        }
    }
}
