using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square(2.2, "red");
        double equal = s.GetArea();
        string type = s.GetColor();

        Console.WriteLine(equal);
        Console.WriteLine(type);


        Rectangle r = new Rectangle(2.0, 3.0, "Blue");
        double rec = r.GetArea();
        string col = r.GetColor();

        Console.WriteLine(rec);
        Console.WriteLine(col);


        Circle circle = new Circle("yellow", 7.0);
        double circ = circle.GetArea();
        string ctype = circle.GetColor();

        Console.WriteLine(circ);
        Console.WriteLine(ctype);

        List<Shape> _shapes = new List<Shape>();
        _shapes.Add(s);
        _shapes.Add(r);
        _shapes.Add(circle);

        foreach (Shape z in _shapes)
        {
            string color1 = z.GetColor();
            double area2 = z.GetArea();

            Console.WriteLine($"The {color1} shape has an area of {area2}.");
        }

    }
}

