namespace Lara.Randomizers
{
    /// <summary>
    /// Contains information of a State (Name, Initials and Capital)
    /// </summary>
    public interface IRandomState
    {
        /// <summary>
        /// The name of the State.
        /// Examples: "Florida", "Louisiana".
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The two letter abbreviation of the State.
        /// Examples: "FL", "LA".
        /// </summary>
        string Abbreviation { get; set; }

        /// <summary>
        /// The capital city of the State.
        /// Examples: "Tallahassee", "Baton Rouge".
        /// </summary>
        string Capital { get; set; }
    }
}
