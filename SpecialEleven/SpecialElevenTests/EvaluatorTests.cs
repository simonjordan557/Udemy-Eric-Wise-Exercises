using NUnit.Framework;
using SpecialElevenLibrary;

namespace SpecialElevenTests
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
        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]

        public void SpecialEleven_WrittenTestCases(int n, bool expectedResult)
        {
            bool result = _evaluator.SpecialEleven(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}