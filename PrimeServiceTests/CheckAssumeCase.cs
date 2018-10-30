using NUnit.Framework;

namespace Prime.UnitTests.Services
{
    public class CheckAssumeCase
    {
        [Test]
        public void TestAssumeFalse()
        {
            Assume.That(false);
        }
    }
}