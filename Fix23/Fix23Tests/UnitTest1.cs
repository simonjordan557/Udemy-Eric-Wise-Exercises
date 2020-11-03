using System;
using Xunit;
using Fix23Library;

namespace Fix23Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Evaluator test = new Evaluator();
            Assert.Equal(test.Fix23(new int[] { 1, 2, 3 }), new int[] { 1, 2, 0 });
        }

        [Fact]
        public void Test3()
        {
            Evaluator test = new Evaluator();
            Assert.Equal(test.Fix23(new int[] { 2, 3, 5 }), new int[] { 2, 0, 5 });
        }

        [Fact]

    public void Test4()
        {
            Evaluator test = new Evaluator();
            Assert.Equal(test.Fix23(new int[] { 1, 2, 1 }), new int[] { 1, 2, 1 });
        }
    }
}
