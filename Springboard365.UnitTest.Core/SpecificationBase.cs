namespace Springboard365.UnitTest.Core
{
    using System;

    public abstract class SpecificationBase : IDisposable
    {
        public SpecificationBase()
        {
            Context();

            BecauseOf();
        }

        protected virtual void Context()
        {
        }

        protected virtual void BecauseOf()
        {
        }

        protected virtual void Cleanup()
        {
        }

        public void Dispose()
        {
            Cleanup();
        }
    }
}