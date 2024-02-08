using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)

    
    {

        List<Shape> shapes = new List<Shape>();


        Square square1 = new Square("purple", 3);
        shapes.Add(square1);

        Circle circle1 = new Circle("blue", 10);
        shapes.Add(circle1);

        Rectangle rec1 = new Rectangle("red", 2, 3);
        shapes.Add(rec1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}