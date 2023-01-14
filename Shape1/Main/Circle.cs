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
