//Lab01_task02_DaniilSarantsev_IU8-31

using lab1;

public class Point
{
    public Point(double x, double y)
    {
        x_ = x;
        y_ = y;
    }
    public double X
    {
        get => x_;
    }
    public double Y
    {
        get => y_;
    }
    public Point()
    {
        x_ = 0;
        y_ = 0;
    }
    private double x_;
    private double y_;
}

public class Figure
{
    List<Point> points_ = new List<Point>();
    public Figure(params Point[] points)
    {
        foreach (Point i in points)
        {
            points_.Add(i);
        }
    }
    public Figure(Point p1, Point p2, Point p3)
    {
        points_.Add(p1);
        points_.Add(p2);
        points_.Add(p3);
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points_.Add(p1);
        points_.Add(p2);
        points_.Add(p3);
        points_.Add(p4);
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points_.Add(p1);
        points_.Add(p2);
        points_.Add(p3);
        points_.Add(p4);
        points_.Add(p5);
    }
    public string Name
    {
        get
        {
            switch(points_.Count)
            {
                case 3:
                    return "Triangle";
                    break;
                case 4:
                    return "Rectangle";
                    break;
                case 5:
                    return "Pentagon";
                    break;
                default:
                    return "Indefinite";
            }
        }
    }
    public double LengthSide(Point A, Point B) => Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    public double PerimeterCalculator()
    {
        if (points_.Count < 3)
        {
            throw new Exception("Error!");
        }
        double result = 0;
        for (int i = 1; i < points_.Count; ++i)
        {
            result += LengthSide(points_[i], points_[i - 1]);
        }
        result += LengthSide(points_[0], points_[points_.Count - 1]);
        return result;
    }
}

