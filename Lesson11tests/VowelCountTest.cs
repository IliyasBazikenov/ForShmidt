using Lesson11;
using System;
using Xunit;

namespace Lesson11tests
{
    public class VowelCountTest
    {
        [Fact]
        
        public void VowelCount_СharacterString_ReturnVowelString()
        {
            var vowelCount = new VowelCount();
            var result = vowelCount.GetVowelCount("SJDjsdkaa");
            Assert.Equal(2, result);
        }
    }
}
