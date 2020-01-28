using System;

namespace Zenburp.Maths
{
    public static class Vector
    {
        public static Vector2 Add(Vector2 a, Vector2 b)
        {
            return new Vector2
            (
                a.x + b.x,
                a.y + b.y
            );
        }        

        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3
            (
                a.x + b.x,
                a.y + b.y,
                a.z + b.z
            );
        }

        public static Vector4 Add(Vector4 a, Vector4 b)
        {
            return new Vector4
            (
                a.x + b.x,
                a.y + b.y,
                a.z + b.z,
                a.w + b.w
            );
        }

        public static Vector2 Subtract(Vector2 a, Vector2 b)
        {
            return new Vector2
            (
                a.x - b.x,
                a.y - b.y
            );
        }

        public static Vector3 Subtract(Vector3 a, Vector3 b)
        {
            return new Vector3
            (
                a.x - b.x,
                a.y - b.y,
                a.z - b.z
            );
        }

        public static Vector4 Subtract(Vector4 a, Vector4 b)
        {
            return new Vector4
            (
                a.x - b.x,
                a.y - b.y,
                a.z - b.z,
                a.w - b.w
            );
        }

        public static Vector2 Multiply(Vector2 a, Single b)
        {
            return new Vector2
            (
                a.x * b,
                a.y * b
            );
        }

        public static Vector3 Multiply(Vector3 a, Single b)
        {
            return new Vector3
            (
                a.x * b,
                a.y * b,
                a.z * b
            );
        }

        public static Vector4 Multiply(Vector4 a, Single b)
        {
            return new Vector4
            (
                a.x * b,
                a.y * b,
                a.z * b,
                a.w * b
            );
        }
    }
}
