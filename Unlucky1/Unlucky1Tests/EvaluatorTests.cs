using NUnit.Framework;
using Unlucky1Library;

namespace Unlucky1Tests
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
        [TestCase(new int[] { 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 1, 1, 1 }, false)]
        public void Evaluator_SuppliedTestCases(int[] numbers, bool expectedResult)
        {
            bool result = evaluator.Go(numbers);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}