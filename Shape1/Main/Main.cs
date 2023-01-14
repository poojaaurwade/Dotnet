using System.Drawing;

static void Main(string[] args)
{
    Circle c = new Circle(5);
    Console.WriteLine("Area of " + c.shapeName + " is: " + c.findArea());
    Console.WriteLine("Perimeter of " + c.shapeName + " is: " + c.findPerimeter());

    Rectangle r = new Rectangle(10, 5);
    Console.WriteLine("Area of " + r.shapeName + " is: " + r.findArea());
    Console.WriteLine("Perimeter of " + r.shapeName + " is: " + r.findPerimeter());
}
