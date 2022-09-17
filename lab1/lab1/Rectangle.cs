//Lab01_task02_DaniilSarantsev_IU8-31
using lab1;
public class Rectangle
{
    public Rectangle(double sideA, double sideB)
    {
        side1_ = sideA;
        side2_ = sideB;
    }
    public Rectangle()
    {
        side1_ = 0;
        side2_ = 0;
    }
    public double AreaCalculator() => (side1_ * side2_);
    public double PerimeterCalculator() => (2 * (side1_ + side2_));
    public double Area
    {
        get => AreaCalculator();
    }
    public double Perimeter
    {
        get => PerimeterCalculator();
    }
    private double side1_;
    private double side2_;
}


