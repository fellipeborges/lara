using NUnit.Framework;
using System;
using Lara;

namespace EntitiesBuilder
{
    public class EntityBuilderTests
    {
        [SetUp]
        public void Setup()
        {
            // Set the Seed to force always same results
            Randomic.SetSeed(1);
        }

        [Test]
        public void Single()
        {
            var ent = EntityBuilder.Fill<BuilderTestsModel>().Build();
            ValidateAllProperties(ent);
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
                ValidateAllProperties(ent);
            });
        }

        private static void ValidateAllProperties(BuilderTestsModel ent)
        {
            Assert.AreEqual(534011718, ent.IntProperty);
            Assert.AreEqual(534011718, ent.LongProperty);
            Assert.AreEqual(4.470298065951377E+307, ent.DoubleProperty);
            Assert.AreEqual(63, ent.ByteProperty);
            Assert.AreEqual(new DateTime(2002, 04, 30, 05, 58, 04, 717), ent.DateTimeProperty);
            Assert.AreEqual("MFYoiWSxFhBMQzji", ent.StringProperty);
            Assert.IsNull(ent.SecondLevelModel);
            Assert.IsNull(ent.SecondLevelModelList);
        }
    }
}
