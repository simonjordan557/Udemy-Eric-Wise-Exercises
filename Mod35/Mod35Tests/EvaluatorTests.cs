using NUnit.Framework;
using Mod35Library;

namespace Mod35Tests
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
        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]

        public void Evaluator_WrittenUnitTests(int n, bool expectedResult)
        {
            bool result = _evaluator.Mod35(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}