using Lesson10;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lesson10Tests
{
    public class TriangleTest
    {
        [Fact]
        public void GetPoint1_Point1byTriangle_ReturnsPoint1()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            Assert.Equal(new Point2D(0, 0), triangle.GetPoint1());
        }

        [Fact]
        public void GetPoint2_Point2ByTriangle_ReturnsPoint2()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            Assert.Equal(new Point2D(0, 3), triangle.GetPoint2());
        }

        [Fact]
        public void GetPoint3_Point3ByTriangle_ReturnsPoint3()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            Assert.Equal(new Point2D(4, 0), triangle.GetPoint3());
        }

        [Fact]
        public void SetPoint1_Point1byTriangle_SetsPoint1ByTriangle()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            triangle.SetPoint1(new Point2D(1, 1));
            Assert.Equal(new Point2D(1, 1), triangle.GetPoint1());
        }

        [Fact]
        public void SetPoint2_Point2byTriangle_SetsPoint2ByTriangle()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            triangle.SetPoint2(new Point2D(1, 7));
            Assert.Equal(new Point2D(1, 7), triangle.GetPoint2());
        }

        [Fact]
        public void SetPoint3_Point3byTriangle_SetsPoint3ByTriangle()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            triangle.SetPoint3(new Point2D(6, 1));
            Assert.Equal(new Point2D(6, 1), triangle.GetPoint3());
        }

        [Fact]
        public void GetSide12_Triangle_ReturnsSide12()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            triangle.GetSide12();
            Assert.Equal(3, triangle.GetSide12());
        }
    }
}
