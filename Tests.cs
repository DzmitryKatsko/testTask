using System;
using AreaLibrary;
using NUnit.Framework;

namespace AreaTest
{

    [TestClass]
    public class AreaCalculatorTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            
            double area = circle.CalculateArea();
            
            Assert.AreEqual(Math.PI * radius * radius, area);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void RightTriangleTest()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);
            
            bool isRight = triangle.IsRightTriangle();
            
            Assert.IsTrue(isRight);
        }
    }

}