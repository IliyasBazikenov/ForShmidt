using Lesson11;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lesson11tests
{
    public class ArgCountTest
    {
        [Theory]
        [InlineData(1, 20, 7)]
        [InlineData(2, 5, 1)]
        [InlineData(1, 14, 5)]
        [InlineData(1, 14, 5, "asdasd")]
        [InlineData(1, 14, 5, "asdasd", "asdasdsada")]
        public void GetArgCount_ValidNumbers_testPassed(params object[] args)
        {
            var catsAndShelvesTask = new ArgCount();
            var result = catsAndShelvesTask.GetArgCount(args);
            Assert.Equal(args.Length, result);
        }        
    }
}
