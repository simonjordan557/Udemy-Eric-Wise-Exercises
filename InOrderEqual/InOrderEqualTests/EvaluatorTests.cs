using NUnit.Framework;
using InOrderEqualLibrary;

namespace InOrderEqualTests
{
    public class EvaluatorTests
    {
        Evaluator _evaluator;
        [SetUp]
        public void Setup()
        {
            _evaluator = new Evaluator();
        }

        [Test]
        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]

        public void Evaluator_WrittenUnitTests(int a, int b, int c, bool equalOK, bool expectedResult)
        {
            bool result = _evaluator.InOrderEqual(a, b, c, equalOK);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}