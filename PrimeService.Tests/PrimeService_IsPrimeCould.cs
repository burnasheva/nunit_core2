using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeCould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeCould()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void ReturnFalseGivenValueOf2()
        {
            var result = _primeService.IsPrime(2);

            Assert.IsFalse(result, $"2 should not be prime");
        }
    }
}
