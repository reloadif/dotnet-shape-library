namespace ShapeLibrary
{
    public class Circle(double radius) : IShape
    {
        private double radius = radius;

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
