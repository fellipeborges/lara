using NUnit.Framework;
using System;
using Lara;
using System.Collections.Generic;
using System.Linq;

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
        public void EmptyArray()
        {
            int[] emptyArray = new int[] { };
            int retValue = Randomic.Among(emptyArray);
            Assert.AreEqual((int)default, retValue);
        }

        [Test]
        public void ArrayWithOneElement()
        {
            string[] oneElementArray = new string[] { "ABC" };
            string retValue = Randomic.Among(oneElementArray);
            Assert.AreEqual(oneElementArray[0], retValue);
        }

        [Test]
        public void ArrayWithMultipleElements()
        {
            long[] multipleElementArray = new long[] {
                1452, 4745, 1265, 4587, 1249, 1233, 8547, 1454, 4136, 9999, 9854, 1469, 4139
            };

            long retValue = Randomic.Among(multipleElementArray);
            Assert.AreEqual(multipleElementArray[2], retValue);
        }

        [Test]
        public void EmptyEnumerable()
        {
            var intList = new List<int>();
            int retValue = Randomic.Among<int>(intList);
            Assert.AreEqual((int)default, retValue);
        }

        [Test]
        public void Enumerable()
        {
            var guidList = new List<string>{
                "824bec01-7fbe-4d24-aa1a-bce13a98d072",
                "fe218fc9-462d-48d7-bd51-b0b9ffc2cf38",
                "981333cd-4b23-4505-b379-d1302e6f2857",
                "e581025a-8b6f-4713-bc0b-37e6a0cdfc08",
                "65a3f10e-372d-49cd-a2f4-2d8cc85d8cff"
            };

            string retValue = Randomic.Among<string>(guidList);
            Assert.AreEqual(guidList[0], retValue);
        }
    }
}
