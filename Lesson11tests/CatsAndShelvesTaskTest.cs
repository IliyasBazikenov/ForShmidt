using Lesson11;
using System;
using Xunit;

namespace Lesson11tests
{
    public class CatsAndShelvesTaskTest
    {
        [Theory]
        [InlineData(1, 20, 7)]
        [InlineData(2, 5, 1)]
        [InlineData(1, 14, 5)]
        public void GetMinumnumbersOfJump_StartShelf1FinishShelf5_Returns2(int start, int finish, int expectedResult)
        {
            var catsAndShelvesTask = new CatsAndShelvesTask();
            var result = catsAndShelvesTask.GetMinumNumbersOfJump(start, finish);
            Assert.Equal(expectedResult, result);
        }
    }
}
