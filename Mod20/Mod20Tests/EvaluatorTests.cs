using NUnit.Framework;
using Mod20Library;

namespace Mod20Tests
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
        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(22, true)]

        public void Evaluator_WrittenTestCases(int n, bool expectedResult)
        {
            bool result = _evaluator.Mod20(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}