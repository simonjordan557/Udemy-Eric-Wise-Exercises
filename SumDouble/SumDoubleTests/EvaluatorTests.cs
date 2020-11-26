using NUnit.Framework;
using SumDoubleLibrary;

namespace SumDoubleTests
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
        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]

        public void Evaluator_WrittenUnitTests(int a, int b, int expectedResult)
        {
            int result = _evaluator.SumDouble(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}