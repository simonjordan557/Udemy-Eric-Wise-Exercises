using NUnit.Framework;
using AnswerCellLibrary;

namespace AnswerCellTests
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
        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void Evaluator_WrittenUnitTests(bool isMorning, bool isMom, bool isAsleep, bool expectedResult)
        {
            bool result = _evaluator.AnswerCell(isMorning, isMom, isAsleep);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}