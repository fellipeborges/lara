namespace Lara
{
    public enum PreDefinedFormat
    {
        /// <summary>
        /// dd/MM/yyyy
        /// Example: 18/05/1986
        /// </summary>
        Brazilian = 1,

        /// <summary>
        /// dd/MM/yyyy HH:mm:ss
        /// Example: 18/05/1986 15:40:41
        /// </summary>
        BrazilianWithTime = 2,

        /// <summary>
        /// MM/dd/yyyy
        /// Example: 05/18/1986
        /// </summary>
        American = 3,

        /// <summary>
        /// MM/dd/yyyy HH:mm:ss
        /// Example: 05/18/1986 03:40:41 PM
        /// </summary>
        AmericanWithTime = 4,

        /// <summary>
        /// yyyy-MM-dd
        /// Example: 1986-05-18
        /// </summary>
        YearMonthDay = 5,

        /// <summary>
        /// yyyy-MM-dd HH:mm:ss
        /// Example: 1986-05-18 15:40:41
        /// </summary>
        YearMonthDayWithTime = 6,

        /// <summary>
        /// MM/yyyy
        /// Example: 05/1986
        /// </summary>
        MonthYear = 7
    }
}
