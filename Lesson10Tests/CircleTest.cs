using Lesson10;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lesson10Tests
{
    public class CircleTest
    {
        [Fact]
        public void GetCenter_EmptyConstructor_ReturnsValid()
        {
            Circle circle = new Circle();
            Point2D result = circle.GetCenter();
            Assert.Equal(new Point2D(0, 0), result);
        }

        [Fact]
        public void GetCenter_CircleWithCenterTen_ReturnsValidCenter()
        {
            Circle circle = new Circle( new Point2D(10, 10),1);
            Point2D result = circle.GetCenter();
            Assert.Equal(new Point2D(10, 10), result);
        }

        [Fact]
        public void GetRadius_EmptyConstructor_ReturnsOne()
        {
            Circle circle = new Circle();
            int result = circle.GetRadius();
            Assert.Equal(1, result);
        }

        [Fact]
        public void GetRadius_CircleWithRadiusNine_ReturnsNine()
        {
            Circle circle = new Circle(new Point2D(), 9);
            int result = circle.GetRadius();
            Assert.Equal(9, result);
        }

        [Fact]
        public void SetCenter_EmptyConstructor_CenterEqualsTen()
        {
            Circle circle = new Circle();
            circle.SetCenter(new Point2D(10, 10));
            Assert.Equal(new Point2D(10, 10), circle.GetCenter());
        }

        [Fact]
        public void SetRadius_EmptyConstructor_RadiusEqualsTen()
        {
            Circle circle = new Circle();
            circle.SetRadius(10);
            Assert.Equal(10, circle.GetRadius());
        }

        [Fact]
        public void MoveRel_MoveCircleByTwoPointRight_CircleMovedTwoPointsRight()
        {
            Circle circle = new Circle();
            circle.MoveRel(2, 0);
            Assert.Equal(new Point2D(2, 0), circle.GetCenter());
        }

        [Fact]
        public void Enlarge_IncreaseRadiusByTwo_RadiusIncreasedByTwo()
        {
            Circle circle = new Circle();
            circle.Enlarge(2);
            Point2D result = circle.GetCenter();
            Assert.Equal(2, circle.GetRadius());
            Assert.Equal(new Point2D(0, 0), result);
        }

        [Fact]
        public void GetArea_DefaultCircle_ReturnsSquare()
        {
            Circle circle = new Circle();
            double result = circle.GetArea();
            Assert.Equal(3.14, result);
        }

        [Fact]
        public void GetPerimeter_DefaultCircle_ReturnsSix()
        {
            Circle circle = new Circle();
            double result = circle.GetPerimeter();
            Assert.Equal(6.28, result);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        [InlineData(-2, 3)]
        public void IsInside_PointIsInsideCircle_ReturnsTrue(int x, int y)
        {
            Circle circle = new Circle(new Point2D(0, 0), 4);
            bool result = circle.IsInside(x, y);
            Assert.True(result);
        }

        [Theory]
        [InlineData(4, 5)]
        [InlineData(-4, 6)]
        [InlineData(10, 12)]
        public void IsInside_PointNotIsInsideCircle_ReturnsFalse(int x, int y)
        {
            Circle circle = new Circle(new Point2D(0, 0), 4);
            bool result = circle.IsInside(x, y);
            Assert.False(result);
        }

        [Fact]
        public void IsInside_Point2DIsInsideCircle_ReturnsTrue()
        {
            Circle circle = new Circle(new Point2D(0, 0), 4);
            Point2D point2D = new Point2D(2, 2);
            bool result = circle.IsInside(point2D);
            Assert.True(result);
        }

        [Fact]
        public void IsInside_Point2DNotIsInsideCircle_ReturnsFalse()
        {
            Circle circle = new Circle(new Point2D(0, 0), 4);
            Point2D point2D = new Point2D(6, 4);
            bool result = circle.IsInside(point2D);
            Assert.False(result);
        }
    }
}
