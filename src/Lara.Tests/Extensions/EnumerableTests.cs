using Lara;
using NUnit.Framework;

namespace Extensions
{
    public class EnumerableTests
    {
        [Test]
        public void In()
        {
            var collection = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21 };
            int valueIn = 5;
            Assert.IsTrue(valueIn.In(collection));
            
            int valueNotIn = 42;
            Assert.IsFalse(valueNotIn.In(collection));
        }
    }
}
