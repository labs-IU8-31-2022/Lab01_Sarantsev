using System.Drawing;
using lab1;
namespace tests;


[TestClass]
public class UnitTestTask2
{
    private const double side1_ = 4;
    private const double side2_ = 5;
    [TestMethod]
    public void TEST_Rectangle_isEmpty()
    {
        var rectangle = new Rectangle();
        Assert.AreEqual(0, rectangle.Area);
        Assert.AreEqual(0, rectangle.Perimeter);
    }
    [TestMethod]
    public void TEST_Rectangle_Area()
    {
        var rectangle = new Rectangle(side1_, side2_);
        Assert.AreEqual(20, rectangle.AreaCalculator());
    }
    [TestMethod]
    public void TEST_Rectangle_Perimeter()
    {
        var rectangle = new Rectangle(side1_, side2_);
        Assert.AreEqual(18, rectangle.PerimeterCalculator());
    }
}
[TestClass]
public class UnitTestTask3
{
    [TestMethod]
    public void TEST_Figure_Triangle()
    {
        var point1 = new Point(5, 6);
        var point2 = new Point(8, 10);
        var point3 = new Point(10, 12);
        var test_figure = new Figure(point1, point2, point3);
        Assert.AreEqual("Triangle", test_figure.Name);
        Assert.AreEqual(5, test_figure.LengthSide(point1, point2));
        Assert.AreEqual(15.638676800652844, test_figure.PerimeterCalculator());
    }
    [TestMethod]
    public void TEST_Figure_Rectangle()
    {
        var point1 = new Point(5, 6);
        var point2 = new Point(8, 10);
        var point3 = new Point(10, 12);
        var point4 = new Point(12, 14);
        var test_figure = new Figure(point1, point2, point3, point4);
        Assert.AreEqual("Rectangle", test_figure.Name);
        Assert.AreEqual(5, test_figure.LengthSide(point1, point2));
        Assert.AreEqual(21.28700006222703, test_figure.PerimeterCalculator());
    }
    [TestMethod]
    public void TEST_Figure_Pentagon()
    {
        var point1 = new Point(5, 6);
        var point2 = new Point(8, 10);
        var point3 = new Point(10, 12);
        var point4 = new Point(12, 14);
        var point5 = new Point(14, 16);
        var test_figure = new Figure(point1, point2, point3, point4, point5);
        Assert.AreEqual("Pentagon", test_figure.Name);
        Assert.AreEqual(5, test_figure.LengthSide(point1, point2));
        Assert.AreEqual(26.938905421312278, test_figure.PerimeterCalculator());
    }
}

