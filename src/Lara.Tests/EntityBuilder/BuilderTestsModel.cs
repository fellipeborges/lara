using System;
using System.Collections.Generic;

namespace EntitiesBuilder
{
    public class BuilderTestsModel
    {
        public int IntProperty { get; set; }
        
        public long LongProperty { get; set; }
        
        public string StringProperty { get; set; }

        public double DoubleProperty { get; set; }

        public byte ByteProperty { get; set; }

        public bool BoolProperty { get; set; }

        public DateTime DateTimeProperty { get; set; }

        public BuilderTestsSecondLevelModel SecondLevelModel { get; set; }

        public List<BuilderTestsSecondLevelModel> SecondLevelModelList { get; set; }
    }

    public class BuilderTestsSecondLevelModel
    {
        public int SecondLevelIntProperty { get; set; }

        public string SecondLevelStringProperty { get; set; }
    }
}
