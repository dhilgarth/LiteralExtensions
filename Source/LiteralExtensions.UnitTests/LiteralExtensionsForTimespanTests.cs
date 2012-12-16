using System;
using Xunit;
using Xunit.Extensions;

namespace LiteralExtensions.UnitTests
{
    public class LiteralExtensionsForTimespanTests
    {
        [Fact]
        public void ExtensionsResideInTheSameNamespaceThanTimeSpan()
        {
            var expected = typeof(TimeSpan).Namespace;

            var actual = typeof(TimeSpanExtensions).Namespace;

            Assert.Equal(expected, actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForDays_ReturnsTheCorrectResult_ForADouble(double x)
        {
            var actual = x.Days();

            Assert.Equal(TimeSpan.FromDays(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForDays_ReturnsTheCorrectResult_ForAnInt(int x)
        {
            var actual = x.Days();

            Assert.Equal(TimeSpan.FromDays(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForHours_ReturnsTheCorrectResult_ForADouble(double x)
        {
            var actual = x.Hours();

            Assert.Equal(TimeSpan.FromHours(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForHours_ReturnsTheCorrectResult_ForAnInt(int x)
        {
            var actual = x.Hours();

            Assert.Equal(TimeSpan.FromHours(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForMilliseconds_ReturnsTheCorrectResult_ForAnInt(int x)
        {
            var actual = x.Milliseconds();

            Assert.Equal(TimeSpan.FromMilliseconds(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForMilliseconds_ReturnsTheCorrectResult_ForADouble(double x)
        {
            var actual = x.Milliseconds();

            Assert.Equal(TimeSpan.FromMilliseconds(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForMinutes_ReturnsTheCorrectResult_ForADouble(double x)
        {
            var actual = x.Minutes();

            Assert.Equal(TimeSpan.FromMinutes(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForMinutes_ReturnsTheCorrectResult_ForAnInt(int x)
        {
            var actual = x.Minutes();

            Assert.Equal(TimeSpan.FromMinutes(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForSeconds_ReturnsTheCorrectResult_ForADouble(double x)
        {
            var actual = x.Seconds();

            Assert.Equal(TimeSpan.FromSeconds(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForSeconds_ReturnsTheCorrectResult_ForAnInt(int x)
        {
            var actual = x.Seconds();

            Assert.Equal(TimeSpan.FromSeconds(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForTicks_ReturnsTheCorrectResult_ForALong(long x)
        {
            var actual = x.Ticks();

            Assert.Equal(TimeSpan.FromTicks(x), actual);
        }

        [Theory, AutoLiteralExtensionsData]
        public void RequestingATimespanForTicks_ReturnsTheCorrectResult_ForAnInt(int x)
        {
            var actual = x.Ticks();

            Assert.Equal(TimeSpan.FromTicks(x), actual);
        }
    }
}
