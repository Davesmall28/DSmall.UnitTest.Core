namespace Springboard365.UnitTest.Core
{
    public abstract class Specification<TUnderTest> : SpecificationBase
        where TUnderTest : class
    {
        public SpecificationFixtureBase<TUnderTest> TestFixture { get; set; }
    }
}