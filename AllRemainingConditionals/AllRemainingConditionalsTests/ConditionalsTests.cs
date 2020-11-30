using NUnit.Framework;
using AllRemainingConditionalsLibrary;

namespace AllRemainingConditionalsTests
{
    public class ConditionalsTests
    {
        Conditionals _conditionals;

        [SetUp]
        public void Setup()
        {
            _conditionals = new Conditionals();
        }

        [Test]
        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]

        public void Diff21_WrittenUnitTests(int n, int expectedResult)
        {
            int result = _conditionals.Diff21(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]

        public void ParrotTrouble_WrittenUnitTests(bool isTalking, int hour, bool expectedResult)
        {
            bool result = _conditionals.ParrotTrouble(isTalking, hour);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]

        public void Makes10_WrittenUnitTests(int a, int b, bool expectedResult)
        {
            bool result = _conditionals.Makes10(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]

        public void NearHundred_WrittenUnitTests(int n, bool expectedResult)
        {
            bool result = _conditionals.NearHundred(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]

        public void PosNeg_WrittenUnitTests(int a, int b, bool negative, bool expectedResult)
        {
            bool result = _conditionals.PosNeg(a, b, negative);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotString_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _conditionals.NotString(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]

        public void MissingChar_WrittenUnitTests(string s, int n, string expectedResult)
        {
            string result = _conditionals.MissingChar(s, n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]

        public void Front3_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _conditionals.Front3(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]

        public void BackAround_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _conditionals.BackAround(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]

        public void Multiple3or5_WrittenUnitTests(int n, bool expectedResult)
        {
            bool result = _conditionals.Multiple3or5(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]

        public void StartHi_WrittenUnitTests(string s, bool expectedResult)
        {
            bool result = _conditionals.StartHi(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]

        public void IcyHot_WrittenUnitTests(int temp1, int temp2, bool expectedResult)
        {
            bool result = _conditionals.IcyHot(temp1, temp2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]

        public void Between10and20_WrittenUnitTests(int a, int b, bool expectedResult)
        {
            bool result = _conditionals.Between10and20(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]

        public void HasTeen_WrittenUnitTests(int a, int b, int c, bool expectedResult)
        {
            bool result = _conditionals.HasTeen(a, b, c);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]

        public void SoAlone_WrittenUnitTests(int a, int b, bool expectedResult)
        {
            bool result = _conditionals.SoAlone(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]

        public void RemoveDel_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _conditionals.RemoveDel(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]

        public void IxStart_WrittenUnitTests(string s, bool expectedResult)
        {
            bool result = _conditionals.IxStart(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void StartOz_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _conditionals.StartOz(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]

        public void Max_WrittenUnitTests(int a, int b, int c, int expectedResult)
        {
            int result = _conditionals.Max(a, b, c);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]

        public void Closer_WrittenUnitTests(int a, int b, int expectedResult)
        {
            int result = _conditionals.Closer(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]

        public void GotE_WrittenUnitTests(string s, bool expectedResult)
        {
            bool result = _conditionals.GotE(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]

        public void EndUp_WrittenUnitTests(string s, string expectedResult)
        {
            string result = _conditionals.EndUp(s);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNth_WrittenUnitTests(string s, int n, string expectedResult)
        {
            string result = _conditionals.EveryNth(s, n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

            
    }
}