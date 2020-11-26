using NUnit.Framework;
using AreInOrderLibrary;

namespace AreInOrderTests
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
        [TestCase(1, 2, 4, false, true)]
        [TestCase(1, 2, 1, false, false)]
        [TestCase(1, 1, 2, true, true)]
        public void Evaluator_WrittenUnitTests(int a, int b, int c, bool bOK, bool expectedResult)
        {
            bool result = _evaluator.AreInOrder(a, b, c, bOK);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}