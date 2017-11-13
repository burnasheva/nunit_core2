using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeCould2
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeCould2()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void ReturnFalseGivenValueOf3()
        {
            var result = _primeService.IsPrime(3);

            Assert.IsFalse(result, $"3 should not be prime");
        }
    }
}
