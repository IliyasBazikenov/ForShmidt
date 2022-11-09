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
    }
}
