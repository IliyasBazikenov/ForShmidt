using Lesson11;
using System;
using Xunit;

namespace Lesson11tests
{
    public class VowelCountTest
    {
        [Theory]
        [InlineData("HalfhHKLAFH")]
        [InlineData("hJGBBjlMBNM")]
        [InlineData("iqoyrqiHF")]

        public void VowelCount_СharacterString_ReturnVowelString(string str)
        {
            var vowelCount = new VowelCount();
            var result = vowelCount.GetVowelCount(str);
            Assert.Equal(result, );
        }
    }
}
