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
        public void GetPoint1_Triangle_ReturnsPoint1()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            Assert.Equal(new Point2D(0, 0), triangle.GetPoint1());
        }

        [Fact]
        public void GetPoint2_Triangle_ReturnsPoint2()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            Assert.Equal(new Point2D(0, 3), triangle.GetPoint2());
        }

        [Fact]
        public void GetPoint3_Triangle_ReturnsPoint3()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            Assert.Equal(new Point2D(4, 0), triangle.GetPoint3());
        }

        [Fact]
        public void SetPoint1_Triangle_SetsPoint1ByTriangle()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            triangle.SetPoint1(new Point2D(1, 1));
            Assert.Equal(new Point2D(1, 1), triangle.GetPoint1());
        }

        [Fact]
        public void SetPoint2_Triangle_SetsPoint2ByTriangle()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            triangle.SetPoint2(new Point2D(1, 7));
            Assert.Equal(new Point2D(1, 7), triangle.GetPoint2());
        }

        [Fact]
        public void SetPoint3_Triangle_SetsPoint3ByTriangle()
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

        [Fact]
        public void GetSide13_Triangle_ReturnsSide13()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            triangle.GetSide13();
            Assert.Equal(4, triangle.GetSide13());
        }

        [Fact]
        public void GetSide23_Triangle_ReturnsSide23()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            triangle.GetSide23();
            Assert.Equal(5, triangle.GetSide23());
        }

        [Fact]
        public void MoveRel_MoveTriangleByFourPointRigth_TriangleMovedFourPointRight()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            triangle.MoveRel(4, 0);
            Assert.Equal(new Point2D(4, 0), triangle.GetPoint1());
            Assert.Equal(new Point2D(4, 3), triangle.GetPoint2());
            Assert.Equal(new Point2D(8, 0), triangle.GetPoint3());
        }

        [Fact]
        public void GetArea_Triangle_ReturnsSix()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            Assert.Equal(6, triangle.GetArea());
        }

        [Fact]
        public void GetPerimeter_Triangle_ReturnsTwelve()
        {
            Triangle triangle = new Triangle(new Point2D(0, 0), new Point2D(0, 3), new Point2D(4, 0));
            Assert.Equal(12, triangle.GetPerimeter());
        }

    }
}
