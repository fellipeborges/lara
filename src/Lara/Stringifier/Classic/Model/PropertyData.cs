namespace Lara.Stringifier
{
    internal class PropertyData
    {
        internal string Name { get; set; }

        internal object Value { get; set; }

        internal bool IsUserDefinedType { get; set; }

        internal PropertyClassification Classification { get; set; }
    }
}