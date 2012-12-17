namespace System
{
    /// <summary>Contains literal extension methods for <see cref="TimeSpan"/>.</summary>
    public static class TimeSpanExtensions
    {
        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of days.</summary>
        /// <param name="value">The days the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Days(this int value)
        {
            return TimeSpan.FromDays(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of days.</summary>
        /// <param name="value">The days the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Days(this double value)
        {
            return TimeSpan.FromDays(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of hours.</summary>
        /// <param name="value">The hours the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Hours(this int value)
        {
            return TimeSpan.FromHours(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of hours.</summary>
        /// <param name="value">The hours the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Hours(this double value)
        {
            return TimeSpan.FromHours(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of milliseconds.</summary>
        /// <param name="value">The milliseconds the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Milliseconds(this int value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of milliseconds.</summary>
        /// <param name="value">The milliseconds the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Milliseconds(this double value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of minutes.</summary>
        /// <param name="value">The minutes the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Minutes(this int value)
        {
            return TimeSpan.FromMinutes(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of minutes.</summary>
        /// <param name="value">The minutes the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Minutes(this double value)
        {
            return TimeSpan.FromMinutes(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of seconds.</summary>
        /// <param name="value">The seconds the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Seconds(this int value)
        {
            return TimeSpan.FromSeconds(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of seconds.</summary>
        /// <param name="value">The seconds the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Seconds(this double value)
        {
            return TimeSpan.FromSeconds(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of ticks.</summary>
        /// <param name="value">The ticks the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Ticks(this long value)
        {
            return TimeSpan.FromTicks(value);
        }

        /// <summary>Returns a <see cref="TimeSpan"/> that represents a specified number of ticks.</summary>
        /// <param name="value">The ticks the <see cref="TimeSpan"/> should represent.</param>
        /// <returns>A <see cref="TimeSpan"/> that represents <paramref name="value"/>.</returns>
        public static TimeSpan Ticks(this int value)
        {
            return TimeSpan.FromTicks(value);
        }
    }
}
