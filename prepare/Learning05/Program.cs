using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        Square s = new Square("red", 5);
        Rectangle r = new Rectangle("Green", 5, 3);
        Circle c = new Circle("Blue", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape ss in shapes)
        {
            Console.WriteLine(ss.GetColor());
            Console.WriteLine(ss.GetArea());
        }
        


    }
}