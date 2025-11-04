using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

List<string> nameList = new();
nameList.Add("Marek");
nameList.Add("Ewa");
nameList.Add("Łukasz");
nameList.Add("Paweł");
nameList.Add("Adam");
void writeNames()
{
    var i = 1;
    foreach (string name in nameList)
    {
        Console.WriteLine($"{i}. {name}");
        i++;
    }
    Console.WriteLine("\n");
}



Console.WriteLine("list not sorted:");
writeNames();

Console.WriteLine("list sorted:");
nameList.Sort();
writeNames();

Console.WriteLine("list sorted in reverse order:");
nameList.Reverse();
writeNames();



double[] quadTriFunc(double a, double b, double c)
{
    double delta = b * b - 4 * a * c;

    if (delta > 0)
    {
        double[] x = [(-b + delta) / 2 * a, (-b - delta) / 2 * a];
        return x;
    }
    else if (delta == 0)
    {
        double[] x = [-b / 2 * a];
        return x;
    }
    else { return null; }
}

Console.WriteLine("input a, b, c for y=ax2+bx+c\n");

double.TryParse(Console.ReadLine(), out double a);

if (a == 0) throw new Exception("wrong value");

double.TryParse(Console.ReadLine(), out double b);
double.TryParse(Console.ReadLine(), out double c);

double[] x = quadTriFunc(a, b, c);

if (x.Length == 2) Console.WriteLine($"x1:{x[0]}\nx2:{x[1]}");

else if (x.Length == 1) Console.WriteLine($"x:{x[0]}");

else Console.WriteLine("there's no x");

List<Shape> shapes = new List<Shape>
{
    new Circle { center = new Point(2, 5), radious = 6 },
    new Rectangle{TopLeft = new Point(1, 10), BottomRight = new Point(10, 0)},
    new Triangle{pointA = new Point(0,0), pointB = new Point(3,3), pointC = new Point(3,0)}
};
foreach (var shape in shapes)
{
    Console.WriteLine($"Area of {shape}: {shape.CalculateArea()}");
    Console.WriteLine($"Circumference of {shape}: {shape.CalculateCircumference()}\n");
}

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculateCircumference();
}
class Circle : Shape
{
    public Point center = new Point();
    public double radious;

    public override double CalculateArea()
    {
        return radious * radious * Math.PI;
    }

    public override double CalculateCircumference()
    {
       return 2 * Math.PI * radious;
    }
}

class Rectangle : Shape
{
    public Point TopLeft = new Point();
    public Point BottomRight = new Point();
    public override double CalculateArea()
    {
        return Math.Abs((BottomRight.X - TopLeft.X) * (BottomRight.Y - TopLeft.Y));
    }
    public override double CalculateCircumference()
    {
        return 2 * Math.Abs(BottomRight.X - TopLeft.X) + 2 * Math.Abs(BottomRight.Y - TopLeft.Y);
    }
}

class Triangle : Shape
{
    public Point pointA = new Point();
    public Point pointB = new Point();
    public Point pointC = new Point();
    public override double CalculateArea()
    {
        return Math.Abs((pointA.X * (pointB.Y - pointC.Y) + pointB.X * (pointC.Y - pointA.Y) + pointC.X * (pointA.Y - pointB.Y)) / 2.0);
    }
    public override double CalculateCircumference()
    {
        double sideAB = Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
        double sideBC = Math.Sqrt(Math.Pow(pointC.X - pointB.X, 2) + Math.Pow(pointC.Y - pointB.Y, 2));
        double sideCA = Math.Sqrt(Math.Pow(pointA.X - pointC.X, 2) + Math.Pow(pointA.Y - pointC.Y, 2));
        return sideAB + sideBC + sideCA;
    }
}