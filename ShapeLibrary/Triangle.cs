namespace ShapeLibrary
{
    public class Triangle(double sideA, double sideB, double sideC) : IShape
    {
        private double sideA = sideA;
        private double sideB = sideB;
        private double sideC = sideC;

        public double GetArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public bool IsRightAngled()
        {
            return sideA * sideA + sideB * sideB == sideC * sideC ||
                   sideA * sideA + sideC * sideC == sideB * sideB ||
                   sideB * sideB + sideC * sideC == sideA * sideA;
        }
    }
}
