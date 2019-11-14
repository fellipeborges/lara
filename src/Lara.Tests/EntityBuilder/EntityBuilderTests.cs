using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using Lara;

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
        public void Single_WithRules()
        {
            var ent = EntityBuilder
                .Fill<BuilderTestsModel>()
                .WithRule(x => x.StringProperty, EntityBuilderStringRule.FullName)
                .WithRule(x => x.IntProperty, EntityBuilderIntRule.OnlyNegatives)
                .Build();
        }

        [Test]
        public void List()
        {
            const int QUANTITY = 10;
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
