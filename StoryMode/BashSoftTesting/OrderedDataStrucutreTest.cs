namespace BashSoftTesting
{
    using System;
    using BashSoft.Contracts;
    using BashSoft.DataStructures;
    using NUnit.Framework;

    [TestFixture]
    public class OrderedDataStrucutreTest
    {
        private ISimpleOrderedBag<string> names;

        [SetUp]
        public void Initlize()
        {
            this.names = new SimpleSortedList<string>();
        }

        [Test]
        public void TestEmptyCtor()
        {
            this.names = new SimpleSortedList<string>();

            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestCtorInitialCapacity()
        {
            this.names = new SimpleSortedList<string>(20);

            Assert.AreEqual(this.names.Capacity, 20);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestCtorWithAllParams()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase, 30);

            Assert.AreEqual(this.names.Capacity, 30);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestCtorWithInitialComparator()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);

            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

        [Test]
        public void TestAddIncreaseSize()
        {
            this.names.Add("Nasko");
            Assert.AreEqual(1, this.names.Size);
        }

        [Test]
        public void TestAddNullThrowsException()
        {
            Assert.That(() => this.names.Add(null), Throws.ArgumentNullException);
        }
    }
}
