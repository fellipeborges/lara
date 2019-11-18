using System;
using System.Linq;

namespace Lara.Randomizers
{
    internal class RandomBasic : IRandomBasic
    {
        private Random LocalRandom => new Random(System.Guid.NewGuid().GetHashCode());

        public Guid Guid()
        {
            return System.Guid.NewGuid();
        }

        public int Int(int minValue = 0, int maxValue = int.MaxValue)
        {
            return LocalRandom.Next(minValue, maxValue);
        }

        public double Double(double minValue = 0, double maxValue = double.MaxValue)
        {
            var next = LocalRandom.NextDouble();
            return minValue + (next * (maxValue - minValue));
        }

        public byte Byte()
        {
            return (byte)Int(0, 255);
        }

        public string String()
        {
            return String(16);
        }

        public string String(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return GetRandomChars(chars, length);
        }

        public string Alphanumeric()
        {
            return Alphanumeric(16);
        }

        public string Alphanumeric(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            return GetRandomChars(chars, length);
        }

        private string GetRandomChars(string chars, int length)
        {
            var random = LocalRandom;
            var randomized = new string(
                Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray()
                );

            return randomized;
        }

        public DateTime Date(DateTime? minDate = null, DateTime? maxDate = null)
        {
            minDate ??= new DateTime(1970, 01, 01);
            maxDate ??= new DateTime(2099, 12, 31);

            int range = (maxDate.Value - minDate.Value).Days;
            return minDate.Value.AddDays(LocalRandom.Next(range));
        }

        public DateTime DateTime(DateTime? minDateTime = null, DateTime? maxDateTime = null)
        {
            minDateTime ??= new DateTime(1970, 01, 01, 00, 00, 00);
            maxDateTime ??= new DateTime(2099, 12, 31, 23, 59, 59);

            // Gets a random date
            DateTime date = Date(minDateTime, maxDateTime);

            // Adds a random number of milliseconds limited to the time between begin and end time
            DateTime iniTime = new DateTime(1970, 01, 01, minDateTime.Value.Hour, minDateTime.Value.Minute, minDateTime.Value.Second);
            DateTime endTime = new DateTime(1970, 01, 01, maxDateTime.Value.Hour, maxDateTime.Value.Minute, maxDateTime.Value.Second);
            int diffTimeMilliseconds = (int)(endTime - iniTime).TotalMilliseconds;

            if (diffTimeMilliseconds > 1)
            {
                int millisecondsToAdd = Int(1, diffTimeMilliseconds);
                date = date.AddMilliseconds(millisecondsToAdd);
            }
            
            return date;
        }
    }
}
