using System;
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
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from TestContext");
            
            var result = _primeService.IsPrime(3);

            Assert.IsFalse(result, $"3 should not be prime");
        }
        
        [Test]
        public void ThisTestShouldFail()
        {
            Console.WriteLine("some stdOut new text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from TestContext");
            
            var result = _primeService.IsPrime(10);

            Assert.IsTrue(result, $"10 should not be prime");
        }
    }
}
