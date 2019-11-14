using NUnit.Framework;
using System;

namespace Lara.Tests.Builder
{
    public class EntityBuilderTests
    {
        [Test]
        public void Single()
        {
            var ent = EntityBuilder.Fill<BuilderTestsModel>().Build();
            Assert.IsTrue(ent.IntProperty != 0);
            Assert.IsTrue(ent.LongProperty != 0);
            Assert.IsTrue(ent.DoubleProperty != 0);
            Assert.IsTrue(ent.ByteProperty != 0);
            Assert.IsTrue(ent.DateTimeProperty != DateTime.MinValue);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(ent.StringProperty));
        }

        [Test]
        public void RulesAndExceptions()
        {
            string STRING_RETURN_VALUE = Guid.NewGuid().ToString();
            DateTime DATE_RETURN_VALUE = DateTime.Now;

            var ent = EntityBuilder
                .Fill<BuilderTestsModel>()
                .WithRule(x => x.StringProperty, () => { return STRING_RETURN_VALUE; })
                .WithRule(x => x.DateTimeProperty, DATE_RETURN_VALUE)
                .Except(x => x.IntProperty)
                .Build();

            Assert.AreEqual(ent.StringProperty, STRING_RETURN_VALUE);
            Assert.AreEqual(ent.DateTimeProperty, DATE_RETURN_VALUE);
            Assert.AreEqual(0, ent.IntProperty);
        }

        [Test]
        public void List()
        {
            const int QUANTITY = 2;
            var entities = EntityBuilder.Fill<BuilderTestsModel>().BuildList(QUANTITY);

            Assert.AreEqual(QUANTITY, entities.Count);
            entities.ForEach(ent =>
            {
                Assert.IsTrue(ent.IntProperty != 0);
                Assert.IsTrue(ent.LongProperty != 0);
                Assert.IsTrue(ent.DoubleProperty != 0);
                Assert.IsTrue(ent.ByteProperty != 0);
                Assert.IsTrue(ent.DateTimeProperty != DateTime.MinValue);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(ent.StringProperty));
            });
            
        }
    }
}
