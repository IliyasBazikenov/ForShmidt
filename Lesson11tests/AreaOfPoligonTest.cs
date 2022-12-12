using Lesson11;
using System.Collections.Generic;
using Xunit;

namespace Lesson11tests
{
    public class AreaOfPoligonTest
    {
        [Theory]
        [InlineData(9, 7, 254.469)]
        [InlineData(6, 10, 113.097)]
        [InlineData(2, 12, 12.566)]

        public void AreaOfPolygonInsideCircle_PolygonInsideCircle_ReturnArea(double radius, int numberofside, double area)
        {
            AreaOfPoligon areaOfPoligon = new AreaOfPoligon();
            var result = areaOfPoligon.AreaOfPolygonInsideCircle(radius, numberofside);
            Assert.Equal(area, result);
        }
    }
}
