namespace Springboard365.UnitTest.Core
{
    using System;

    public abstract class SpecificationFixture<TUnderTest>
        where TUnderTest : class
    {
        public SpecificationFixture()
        {
            UnderTest = (TUnderTest)Activator.CreateInstance(typeof(TUnderTest));
        }

        public TUnderTest UnderTest { get; set; }

        public virtual void PerformTestSetup()
        {
        }
    }
}