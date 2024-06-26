# ShapeLibrary

A simple .NET library for calculating the area of basic geometric shapes.

## Introduction

The `ShapeLibrary` is a .NET library that provides classes and interfaces to calculate the area of commonly used geometric shapes such as circles and triangles. It includes the following main components:

- `IShape` interface: Defines a method to calculate the area of a shape.
- `Circle` class: Represents a circle shape and implements the `IShape` interface.
- `Triangle` class: Represents a triangle shape and implements the `IShape` interface.

## Usage

To use the `ShapeLibrary` in your .NET project, you can follow these steps:

1. Add a reference to the `ShapeLibrary` assembly in your project.
2. Create instances of `Circle` or `Triangle` classes with the required parameters.
3. Call the `GetArea()` method on the shape instances to calculate their areas.

## Example

```csharp
using ShapeLibrary;

class Program
{
    static void Main()
    {
        // Calculate the area of a circle
        double radius = 5;
        Circle circle = new Circle(radius);
        double circleArea = circle.GetArea();

        // Calculate the area of a triangle
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        Triangle triangle = new Triangle(sideA, sideB, sideC);
        double triangleArea = triangle.GetArea();

        // Check if the triangle is right-angled
        bool isRightAngled = triangle.IsRightAngled();
    }
}
```

## Testing

The library includes test cases for both `Circle` and `Triangle` classes using the xUnit testing framework.

### CircleTests

- `TestCircleAreaCalculation`: Tests the calculation of the area for a circle.

### TriangleTests

- `TestTriangleAreaCalculation`: Tests the calculation of the area for a triangle.
- `TestIsRightAngledTriangle`: Tests whether a triangle is right-angled.

## License

This library is provided under the MIT license.
