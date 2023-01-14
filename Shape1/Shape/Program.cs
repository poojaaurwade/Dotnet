abstract class Shape
{
    public string shapeName { get; set; }

    public abstract double findArea();
    public abstract double findPerimeter();
}

class Circle : Shape
{
    private double radius;
    public Circle(double r)
    {
        radius = r;
        shapeName = "Circle";
    }
    public override double findArea()
    {
        return Math.PI * radius * radius;
    }
    public override double findPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
class Rectangle : Shape
{
    private double length;
    private double width;
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
        shapeName = "Rectangle";
    }
    public override double findArea()
    {
        return length * width;
    }
    public override double findPerimeter()
    {
        return 2 * (length + width);
    }
}



