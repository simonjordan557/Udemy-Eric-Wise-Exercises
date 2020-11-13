using NUnit.Framework;
using Make2Library;

namespace Make2Tests
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
        [TestCase(new int[] { 4, 5 }, new int[] { 1, 2, 3 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 4 }, new int[] { 1, 2, 3 }, new int[] { 4, 1 })]
        [TestCase(new int[] {}, new int[] { 1, 2 }, new int[] { 1, 2 })]

        public void Evaluator_SuppliedUnitTests(int[] a, int[] b, int[] expectedResult)
        {
            Assert.That(expectedResult, Is.EqualTo(evaluator.Go(a, b)));
        }
    }
}