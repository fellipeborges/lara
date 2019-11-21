using Lara;
using NUnit.Framework;
using System.Collections.Generic;

namespace RandomicTests
{
    public class RandomAmongTests
    {
        [SetUp]
        public void Setup()
        {
            // Set the Seed to force always same results
            Randomic.SetSeed(1);
        }

        [Test]
        public void AmongStrings()
        {
            // Array
            string[] array = new string[] { "ABC", "DEF", "GHI" };
            string retValueArray = Randomic.Among.Strings(array);
            Assert.AreEqual(array[0], retValueArray);

            // Enumerable
            var enumerable = new List<string> { "ABC", "DEF", "GHI" };
            string retValueEnumerable = Randomic.Among.Strings(enumerable);
            Assert.AreEqual(enumerable[0], retValueEnumerable);
        }

        [Test]
        public void AmongInts()
        {
            // Array
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int retValueArray = Randomic.Among.Ints(array);
            Assert.AreEqual(array[2], retValueArray);

            // Enumerable
            var enumerable = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int retValueEnumerable = Randomic.Among.Ints(enumerable);
            Assert.AreEqual(enumerable[2], retValueEnumerable);
        }

        [Test]
        public void OtherWithArrays()
        {
            // Empty Array
            int[] emptyArray = new int[] { };
            int retValueEmptyArray = Randomic.Among.Other(emptyArray);
            Assert.AreEqual((int)default, retValueEmptyArray);

            // Array with one element
            string[] oneElementArray = new string[] { "ABC" };
            string retValueOneElementArray = Randomic.Among.Other(oneElementArray);
            Assert.AreEqual(oneElementArray[0], retValueOneElementArray);

            // Array with multiple elements
            long[] multipleElementArray = new long[] { 1452, 4745, 1265, 4587, 1249, 1233, 8547, 1454, 4136, 9999, 9854, 1469, 4139 };
            long retValueMultipleElementArray = Randomic.Among.Other(multipleElementArray);
            Assert.AreEqual(multipleElementArray[2], retValueMultipleElementArray);
        }

        [Test]
        public void OtherWithEnumerables()
        {
            // Empty list
            var intList = new List<int>();
            int retValueEmptyList = Randomic.Among.Other<int>(intList);
            Assert.AreEqual((int)default, retValueEmptyList);

            // Enumerable with one element
            var singleElementList = new List<long> { 50 };
            long retValueOneElementList = Randomic.Among.Other<long>(singleElementList);
            Assert.AreEqual(singleElementList[0], retValueOneElementList);

            // Enumerable with multiple element
            var guidList = new List<string>{
                "824bec01-7fbe-4d24-aa1a-bce13a98d072",
                "fe218fc9-462d-48d7-bd51-b0b9ffc2cf38",
                "981333cd-4b23-4505-b379-d1302e6f2857",
                "e581025a-8b6f-4713-bc0b-37e6a0cdfc08",
                "65a3f10e-372d-49cd-a2f4-2d8cc85d8cff"
            };
            string retValueMultipleElements = Randomic.Among.Other<string>(guidList);
            Assert.AreEqual(guidList[0], retValueMultipleElements);
        }
    }
}
