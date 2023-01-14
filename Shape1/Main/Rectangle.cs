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
