namespace Lara.Randomizers
{
    internal class RandonState : IRandomState
    {
        public RandonState()
        {
        }

        public RandonState(string name, string abbreviation, string capital)
        {
            Name = name;
            Abbreviation = abbreviation;
            Capital = capital;
        }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public string Capital { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
