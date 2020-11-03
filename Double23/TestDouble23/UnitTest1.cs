using Double23Library;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Text.RegularExpressions;
using Xunit;


namespace TestDouble23
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
            Assert.True(test.Go(new int[] { 2, 2, 3 }));
        }

        [Fact]
        public void Test3()
        {
            Evaluator test = new Evaluator();
            Assert.True(test.Go(new int[] { 3, 4, 5, 3 }));
        }

        [Fact]
        public void Test4()
        {
            Evaluator test = new Evaluator();
            Assert.False(test.Go(new int[] { 2, 3, 2, 2 }));
        }
    }
}
