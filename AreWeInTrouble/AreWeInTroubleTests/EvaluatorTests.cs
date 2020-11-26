using NUnit.Framework;
using AreWeInTroubleLibrary;

namespace AreWeInTroubleTests
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
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]

        public void Evaluator_WrittenUnitTests(bool aSmile, bool bSmile, bool expectedResult)
        {
            bool result = _evaluator.AreWeInTrouble(aSmile, bSmile);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}