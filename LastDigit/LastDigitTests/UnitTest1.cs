using NUnit.Framework;
using LastDigitLibrary;

namespace LastDigitTests
{ 
    public class Tests
    {
        Evaluator _evaluator;
        [SetUp]
        public void Setup()
        {
            _evaluator = new Evaluator();
        }

        [Test]
        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 12, false)]
        [TestCase(23, 19, 3, true)]
        public void Evaluator_WrittenUnitTests(int a, int b, int c, bool expectedResult)
        {
            bool result = _evaluator.LastDigit(a, b, c);
            Assert.That(result, Is.EqualTo(expectedResult));       
        }
    }
}