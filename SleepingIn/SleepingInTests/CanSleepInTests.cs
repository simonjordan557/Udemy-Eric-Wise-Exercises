using NUnit.Framework;
using SleepingInLibrary;

namespace SleepingInTests
{
    public class CanSleepInTests
    {
        Evaluator _evaluator;
        [SetUp]
        public void Setup()
        {
            _evaluator = new Evaluator();
        }

        [Test]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]

        public void Evaluator_WrittenUnitTests(bool isWeekday, bool isVacation, bool expectedResult)
        {
            bool result = _evaluator.CanSleepIn(isWeekday, isVacation);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}