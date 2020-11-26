using NUnit.Framework;
using TwoIsOneLibrary;

namespace TwoIsOneTests
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
        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, true)]
        [TestCase(3, 2, 2, false)]
        public void Evaluator_WrittenUnitTests(int a, int b, int c, bool expectedResult)
        {
            bool result = _evaluator.TwoIsOne(a, b, c);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}