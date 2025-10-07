using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Orange", 4);
        shapes.add(s1);

        Rectangle s2 = new Rectangle("Blue", 5, 6);
        shapes.add(s2);

        Circle s3 = new Circle("Gray", 7);
        shapes.add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}