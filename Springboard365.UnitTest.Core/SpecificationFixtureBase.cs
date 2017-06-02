namespace Springboard365.UnitTest.Core
{
    using System;

    public abstract class SpecificationFixtureBase<TUnderTest>
        where TUnderTest : class
    {
        public SpecificationFixtureBase()
        {
            UnderTest = (TUnderTest)Activator.CreateInstance(typeof(TUnderTest));
        }

        public TUnderTest UnderTest { get; set; }

        public virtual void PerformTestSetup()
        {
        }
    }
}