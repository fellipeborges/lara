namespace Lara.Stringifier
{
    internal class NameValue
    {
        internal string Name { get; set; }

        internal string Value { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Value}";
        }
    }
}
