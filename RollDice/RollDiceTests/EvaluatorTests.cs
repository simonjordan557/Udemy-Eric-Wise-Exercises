using NUnit.Framework;
using RollDiceLibrary;

namespace RollDiceTests
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
        [TestCase(2, 3, true, 5)]
        [TestCase(3, 3, true, 7)]
        [TestCase(3, 3, false, 6)]

        public void Evaluator_WrittenUnitTests(int die1, int die2, bool noDoubles, int expectedResult)
        {
            int result = _evaluator.RollDice(die1, die2, noDoubles);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}