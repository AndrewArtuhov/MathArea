using MathArea.Entities;

namespace MathArea.Test
{
    public class CustomerTest
    {
        [Fact]
        public void GetAreaTriangleReturnsZero()
        {
            Triangle triangle = new Triangle(1,2,3);
            var result = triangle.GetArea();
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetAreaTriangleReturnsPositive()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var result = triangle.GetArea();
            Assert.Equal(6, result);
        }

        [Fact]
        public void GetAreaCircleReturnsPositive()
        {
            Circle triangle = new Circle(2);
            var result = triangle.GetArea();
            Assert.Equal(12.57, result);
        }

        [Fact]
        public void GetRightTriangleReturnsTrue()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            var result = triangle.IsRight();
            Assert.True(result);
        }

        [Fact]
        public void GetRightTriangleReturnsFalse()
        {
            Triangle triangle = new Triangle(3, 8, 10);
            var result = triangle.IsRight();
            Assert.False(result);
        }

    }
}
