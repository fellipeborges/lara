namespace Lara.Randomizers
{
    /// <summary>
    /// Contains information of a Phone Number (Country Code, Area, Number, Formated Number, etc.)
    /// </summary>
    public interface IRandomPhone
    {
        /// <summary>
        /// The Country Calling Code.
        /// Examples: "+1", "+55".
        /// </summary>
        string CountryCode { get; set; }

        /// <summary>
        /// The location Area code.
        /// Examples: "866", "11".
        /// </summary>
        string AreaCode { get; set; }

        /// <summary>
        /// The Phone Number.
        /// Examples: "9186329", "23021409".
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// The Phone Number formated with a dash.
        /// Examples: "918-6329", "2302-1409".
        /// </summary>
        string FormatedNumber { get; set; }

        /// <summary>
        /// Returns the phone number in the following format:
        ///  {CountryCode} {AreaCode} {FormatedNumber}
        ///  Examples: "+1 866 918-6329", "+55 11 2302-1409"
        /// </summary>
        string ToString();
    }
}
