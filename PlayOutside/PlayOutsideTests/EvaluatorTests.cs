using NUnit.Framework;
using PlayOutsideLibrary;

namespace PlayOutsideTests
{
    public class EvaluatorTests
    {
        Evaluator evaluator;

        [SetUp]
        public void Setup()
        {
            evaluator = new Evaluator();
        }

        [Test]
        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]
        public void evaluator_WrittenUnitTests(int temp, bool isSummer, bool expectedResult)
        {
            Assert.That(expectedResult, Is.EqualTo(evaluator.Go(temp, isSummer))); 
        }
    }
}