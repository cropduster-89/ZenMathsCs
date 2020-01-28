using NUnit.Framework;
using Zenburp.Maths;

namespace MathsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EqualsTestsEquality()
        {
            Vector2 aVector = new Vector2(2, 2);

            Assert.IsTrue(aVector.Equals(aVector));
        }

        [Test]
        public void AddVec2AddsCorrectly()
        {
            Vector2 expected = new Vector2(2, 2);

            Assert.AreEqual(new Vector2(1, 1) + new Vector2(1, 1), expected);
        }

        [Test]
        public void AddVec3AddsCorrectly()
        {
            Vector3 expected = new Vector3(2, 2, 2);

            Assert.IsTrue(new Vector3(1, 1, 1) + new Vector3(1, 1, 1) == expected);
        }

        [Test]
        public void AddVec4AddsCorrectly()
        {
            Vector4 expected = new Vector4(2, 2, 2, 2);

            Assert.AreEqual(new Vector4(1, 1, 1, 1) + new Vector4(1, 1, 1, 1), expected);
        }

        [Test]
        public void MultipliVec2MultiplysCorrectly()
        {
            Vector2 expected = new Vector2(2, 2);

            Assert.IsTrue(new Vector2(1, 1) * 2 == expected);
        }

        [Test]
        public void MultipliVec3MultiplysCorrectly()
        {
            Vector3 expected = new Vector3(2, 2, 2);

            Assert.IsTrue(new Vector3(1, 1, 1) * 2 == expected);
        }

        [Test]
        public void MultipliVec4MultiplysCorrectly()
        {
            Vector4 expected = new Vector4(2, 2, 2, 2);

            Assert.IsTrue(new Vector4(1, 1, 1, 1) * 2 == expected);
        }

        [Test]
        public void SubtractVec2SubtractsCorrectly()
        {
            Vector2 expected = new Vector2(0, 0);

            Assert.IsTrue(new Vector2(1, 1) - new Vector2(1, 1) == expected);
        }

        [Test]
        public void SubtractVec3SubtractsCorrectly()
        {
            Vector3 expected = new Vector3(0, 0, 0);

            Assert.IsTrue(new Vector3(1, 1, 1) - new Vector3(1, 1, 1) == expected);
        }

        [Test]
        public void SubtractVec4SubtractsCorrectly()
        {
            Vector4 expected = new Vector4(0, 0, 0, 0);

            Assert.IsTrue(new Vector4(1, 1, 1, 1) - new Vector4(1, 1, 1, 1) == expected);
        }

        [Test]
        public void CanExtractXYFromVec3()
        {
            Vector2 expected = new Vector2(2, 2);

            Assert.IsTrue(new Vector3(2, 2, 2).xy == expected);
        }

        [Test]
        public void CanExtractXYZFromVec4()
        {
            Vector3 expected = new Vector3(2, 2, 2);

            Assert.IsTrue(new Vector4(2, 2, 2, 2).xyz == expected);
        }
    }
}