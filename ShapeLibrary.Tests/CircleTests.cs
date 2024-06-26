namespace ShapeLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void TestCircleAreaCalculation()
        {
            // Arrange
            double radius = 5;
            Circle circle = new(radius);

            // Act
            double expectedArea = Math.PI * radius * radius;
            double actualArea = circle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }
    }
}
