using Lara;
using NUnit.Framework;
using System;

namespace Extensions
{
    public class ThrowTests
    {
        private const string MESSAGE = "the_message";

        [Test]
        public void ThrowIfNoValue_MustThrow()
        {
            // Null (object)
            object objectNull = null;
            Assert.Throws<ArgumentNullException>(() => objectNull.ThrowIfNoValue(nameof(objectNull)));
            Assert.Throws<CustomException>(() => objectNull.ThrowIfNoValue<CustomException>(MESSAGE));

            // Empty (string)
            string emptyString = "";
            Assert.Throws<ArgumentNullException>(() => emptyString.ThrowIfNoValue(nameof(emptyString)));
            Assert.Throws<CustomException>(() => emptyString.ThrowIfNoValue<CustomException>(MESSAGE));

            // White space (string)
            string whiteSpace = " ";
            Assert.Throws<ArgumentNullException>(() => whiteSpace.ThrowIfNoValue(nameof(whiteSpace)));
            Assert.Throws<CustomException>(() => whiteSpace.ThrowIfNoValue<CustomException>(MESSAGE));
        }


        [Test]
        public void ThrowIfNoValue_MustNotThrow()
        {
            // Object
            object notNullObject = DateTime.Now;
            Assert.DoesNotThrow(() => notNullObject.ThrowIfNoValue(nameof(notNullObject)));
            Assert.DoesNotThrow(() => notNullObject.ThrowIfNoValue<CustomException>(MESSAGE));

            // String
            string notEmptyString = "a";
            Assert.DoesNotThrow(() => notEmptyString.ThrowIfNoValue(nameof(notEmptyString)));
            Assert.DoesNotThrow(() => notEmptyString.ThrowIfNoValue<CustomException>(MESSAGE));
        }

        [Test]
        public void ThrowIfZero_MustThrow()
        {
            // Null (object)
            int? intNull = null;
            Assert.Throws<ArgumentNullException>(() => intNull.ThrowIfZero(nameof(intNull)));
            Assert.Throws<CustomException>(() => intNull.ThrowIfZero<CustomException>(MESSAGE));

            // Zero (int)
            int intZero = 0;
            Assert.Throws<ArgumentNullException>(() => intZero.ThrowIfZero(nameof(intZero)));
            Assert.Throws<CustomException>(() => intZero.ThrowIfZero<CustomException>(MESSAGE));

            // Zero (long)
            long longZero = 0;
            Assert.Throws<ArgumentNullException>(() => longZero.ThrowIfZero(nameof(longZero)));
            Assert.Throws<CustomException>(() => longZero.ThrowIfZero<CustomException>(MESSAGE));

            // Zero (double)
            double doubleZero = 0;
            Assert.Throws<ArgumentNullException>(() => doubleZero.ThrowIfZero(nameof(doubleZero)));
            Assert.Throws<CustomException>(() => doubleZero.ThrowIfZero<CustomException>(MESSAGE));
        }

        [Test]
        public void ThrowIfZero_MustNotThrow()
        {
            // Int
            int intValue = int.MaxValue;
            Assert.DoesNotThrow(() => intValue.ThrowIfZero(nameof(intValue)));
            Assert.DoesNotThrow(() => intValue.ThrowIfZero<CustomException>(MESSAGE));

            // Long
            long longValue = long.MaxValue;
            Assert.DoesNotThrow(() => longValue.ThrowIfZero(nameof(longValue)));
            Assert.DoesNotThrow(() => longValue.ThrowIfZero<CustomException>(MESSAGE));

            // Double
            double doubleValue = double.MaxValue;
            Assert.DoesNotThrow(() => doubleValue.ThrowIfZero(nameof(doubleValue)));
            Assert.DoesNotThrow(() => doubleValue.ThrowIfZero<CustomException>(MESSAGE));
        }
    }

    public class CustomException : Exception
    {
        public CustomException()
               : base()
        {
        }

        public CustomException(string message)
            : base(message)
        {
        }

        public CustomException(string message, CustomException inner)
            : base(message, inner)
        {
        }
    }
}