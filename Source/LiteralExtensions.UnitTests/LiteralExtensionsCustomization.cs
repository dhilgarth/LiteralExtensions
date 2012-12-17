using Ploeh.AutoFixture;

namespace LiteralExtensions.UnitTests
{
    public class LiteralExtensionsCustomization : CompositeCustomization
    {
        public LiteralExtensionsCustomization()
            : base(new MultipleCustomization())
        {
        }
    }
}
