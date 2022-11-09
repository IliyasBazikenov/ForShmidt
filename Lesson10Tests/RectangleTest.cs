using Lesson10;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lesson10Tests
{
    public class RectangleTest
    {
        [Fact]
        public void GetLength_EmptyConstructor_ReturnsOne()
        {
            Rectangle rectangle = new Rectangle(); // arrange
            var result = rectangle.GetLength(); // act

            Assert.Equal(1, result);
        }

        [Fact]
        public void GetLength_RectangleWithLengthTen_ReturnsTen()
        {
            Rectangle rectangle = new Rectangle(10, 2); 
            var result = rectangle.GetLength();

            Assert.Equal(10, result);
        }

        [Fact]
        public void GetWidth_EmptyConstructor_ReturnsOne()
        {
            Rectangle rectangle = new Rectangle(); 
            var result = rectangle.GetWidth();

            Assert.Equal(1, result);
        }

        [Fact]
        public void GetWidth_RectangleWithWidthEqualsTen_ReturnsTen()
        {
            Rectangle rectangle = new Rectangle(20, 10);
            var result = rectangle.GetWidth();

            Assert.Equal(10, result);
        }

        [Fact]
        public void MoveRel_MoveRectangleByTwoPointRigth_RectangleMovedTwoPointRight()
        {
            Rectangle rectangle = new Rectangle();

            rectangle.MoveRel(2, 0);

            Assert.Equal(3, rectangle.GetBottomRight().GetX());
            Assert.Equal(2, rectangle.GetTopLeft().GetX());
        }

        [Fact]
        public void MoveRel_MoveRectangleByTwoPointHight_RectangleMovedTwoPointHight()
        {
            Rectangle rectangle = new Rectangle();

            rectangle.MoveRel(0, 2);

            Assert.Equal(2, rectangle.GetBottomRight().GetY());
            Assert.Equal(3, rectangle.GetTopLeft().GetY());
        }

        [Fact]
        public void Enlarge_EnlargeRectanleTwoTimes_RectanleEnlardedTwoTimes()
        {
            var rectangle = new Rectangle();
            rectangle.Enlarge(2, 2);

            Assert.Equal(2, rectangle.GetBottomRight().GetX());
            Assert.Equal(-1, rectangle.GetBottomRight().GetY());
        }

        [Fact]
        public void GetArea_DefaultRectangle_ReturnsOne()
        {
            var rectangle = new Rectangle();
            var result = rectangle.GetArea();

            Assert.Equal(1, result);
        }

        [Fact]
        public void GetArea_WidthEqualsTwoLengthEqualsThree_ReturnsSix()
        {
            var rectangle = new Rectangle(3, 2);
            var result = rectangle.GetArea();

            Assert.Equal(6, result);
        }

        [Fact]
        public void GetPerimeter_WidthEqualsTwoLengthEqualsThree_ReturnsTen()
        {
            var rectangle = new Rectangle(3, 2);
            var result = rectangle.GetPerimeter();

            Assert.Equal(10, result);
        }

        [Fact]
        public void GetPerimeter_DefaultRectangle_ReturnsFour()
        {
            var rectangle = new Rectangle();
            var result = rectangle.GetPerimeter();

            Assert.Equal(4, result);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(0, 2)]
        [InlineData(2, 2)]
        public void IsInside_PointIsInsideRectangle_ReturnsTrue(int x, int y)
        {
            Rectangle rectangle = new Rectangle(new Point2D(0, 3), new Point2D(5, 0));

            var result = rectangle.IsInside(new Point2D(x, y));

            Assert.True(result);
        }


        [Theory]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        [InlineData(-10, -3)]
        public void IsInside_PointIsInsideRectangle_ReturnsFalse(int x, int y)
        {
            Rectangle rectangle = new Rectangle(new Point2D(0, 3), new Point2D(5, 0));

            var result = rectangle.IsInside(new Point2D(x, y));

            Assert.False(result);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        [InlineData(5, 3)]
        public void IsInside_RectanleIsInsideRectanngle_ReturnsTrue(int length, int width)
        {
            Rectangle rectangle = new Rectangle(new Point2D(0, 3), new Point2D(5, 0));

            var result = rectangle.IsInside(new Rectangle(length, width));

            Assert.True(result);
        }


        [Theory]
        [InlineData(4, 4, 6, 1)]
        [InlineData(2, 4, 3, 3)]
        public void IsIntersects_RectangleIsIntersects_ReturnTrue (int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            Rectangle rectangle = new Rectangle(new Point2D(1, 3), new Point2D(5, 1));

            var result = rectangle.IsIntersects(new Rectangle(topLeftX, topLeftY, bottomRightX, bottomRightY));

            Assert.True(result);
        }
    }
}
