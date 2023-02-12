using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

public static class Geometry
{
    /// <summary>
    /// Площадь круга по радиусу
    /// </summary>
    /// <param name="radius">Радиус</param>
    /// <returns></returns>
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    /// <summary>
    /// Площадь триугольника по трём сторонам
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static double CalculateTriangleArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2.0;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
    /// <summary>
    /// Проверка на является ли триугольник прямоугольным
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static bool IsTriangleRectangular(double a, double b, double c)
    {
        return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);
    }
}

//Unit Tests
[TestClass]
public static class GeometryTests
{
    [TestMethod]
    public static void CircleAreaTest()
    {
        double radius = 3.0;
        double expectedArea = 28.274333882308138;
        double actualArea = Geometry.CalculateCircleArea(radius);
        Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public static void TriangleAreaTest()
    {
        double a = 3.0;
        double b = 4.0;
        double c = 5.0;
        double expectedArea = 6.0;
        double actualArea = Geometry.CalculateTriangleArea(a, b, c);
        Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public static void IsTriangleRectangularTest()
    {
        double a = 3.0;
        double b = 4.0;
        double c = 5.0;
        bool expectedResult = true;
        bool actualResult = Geometry.IsTriangleRectangular(a, b, c);
        Assert.AreEqual(expectedResult, actualResult);
    }
}   