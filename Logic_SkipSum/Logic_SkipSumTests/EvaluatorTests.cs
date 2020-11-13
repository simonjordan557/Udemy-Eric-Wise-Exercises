using NUnit.Framework;
using Logic_SkipSumLibrary;

namespace Logic_SkipSumTests
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
        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        public void Evaluator_WrittenUnitTests(int a, int b, int expectedResult)
        {
            Assert.That(expectedResult, Is.EqualTo(evaluator.Go(a, b)));
        }
    }
}