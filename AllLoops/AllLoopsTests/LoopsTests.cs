using NUnit.Framework;
using AllLoopsLibrary;

namespace AllLoopsTests
{
    public class LoopsTests
    {
        Loops _loops;
        [SetUp]
        public void Setup()
        {
            _loops = new Loops();
        }

        [Test]
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]

        public void StringTimes_WrittenUnitTests(string s, int n, string expectedResult)
        {
            string result = _loops.StringTimes(s, n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]

        public void FrontTimes_WrittenUnitTests(string s, int n, string expectedResult)
        {
            string result = _loops.FrontTimes(s, n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]

        public void CountXX_WrittenUnitTests(string s, int expectedResult)
        {
            int result = _loops.CountXX(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]

        public void EveryOther_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _loops.EveryOther(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]

        public void StringSplosion_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _loops.StringSplosion(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]

        public void CountLast2_WrittenUnitTests(string s, int expectedResult)
        {
            int result = _loops.CountLast2(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 9 }, 1)]
        [TestCase(new int[] { 1, 9, 9 }, 2)]
        [TestCase(new int[] { 1, 9, 9, 3, 9 }, 3)]

        public void Count9_WrittenUnitTests(int[] numbers, int expectedResult)
        {
            int result = _loops.Count9(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 9, 3, 4 }, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 9 }, false)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, false)]

        public void ArrayFront9_WrittenUnitTests(int[] numbers, bool expectedResult)
        {
            bool result = _loops.ArrayFront9(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 1, 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 4, 1 }, false)]
        [TestCase(new int[] { 1, 1, 2, 1, 2, 3 }, true)]

        public void Array123_WrittenUnitTests(int[] numbers, bool expectedResult)
        {
            bool result = _loops.Array123(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]

        public void SubStringMatch(string a, string b, int expectedResult)
        {
            int result = _loops.SubStringMatch(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]

        public void StringX_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _loops.StringX(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]

        public void AltPairs_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _loops.AltPairs(s);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]

        public void DoNotYak_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _loops.DoNotYak(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 6, 6, 2 }, 1)]
        [TestCase(new int[] { 6, 6, 2, 6 }, 1)]
        [TestCase(new int[] { 6, 7, 2, 6 }, 1)]

        public void Array667_WrittenUnitTests(int[] numbers, int expectedResult)
        {
            int result = _loops.Array667(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 1, 1, 2, 2, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 2, 2, 1 }, false)]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 1 }, false)]

        public void NoTriples_WrittenUnitTests(int[] numbers, bool expectedResult)
        {
            bool result = _loops.NoTriples(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 7, 1 }, true)]
        [TestCase(new int[] { 1, 2, 8, 1 }, false)]
        [TestCase(new int[] { 2, 7, 1 }, true)]

        public void Pattern51_WrittenUnitTests(int[] numbers, bool expectedResult)
        {
            bool result = _loops.Pattern51(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}