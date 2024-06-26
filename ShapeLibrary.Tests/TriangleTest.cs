namespace ShapeLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void TestTriangleAreaCalculation()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double expectedArea = 6;
            double actualArea = triangle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void TestIsRightAngledTriangle()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }
    }
}
