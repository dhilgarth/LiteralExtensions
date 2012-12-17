using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Xunit;

namespace LiteralExtensions.UnitTests
{
    public class AutoLiteralExtensionsDataAttribute : AutoDataAttribute
    {
        public AutoLiteralExtensionsDataAttribute()
            : base(new Fixture().Customize(new LiteralExtensionsCustomization()))
        {
        }
    }
}
