// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

interface Shape
{
  // methods
  int GetArea();
  int GetPerimeter();
}

class Rectangle: Shape
{
  int length;
  int breadth;

  public Rectangle(int l, int b)
  {
    length = l;
    breadth = b;
  }

  public int GetArea()
  {
    return length*breadth;
  }

  public int GetPerimeter()
  {
    return 2*(length+breadth);
  }
}

class Square: Shape
{
  int side;

  public Square(int s)
  {
    side = s;
  }

  public int GetArea()
  {
    return side*side;
  }

  public int GetPerimeter()
  {
    return 4*side;
  }
}

class Interface
{
  static void Main(string[] args)
  {
    Rectangle r = new Rectangle(7, 4);
    Square s = new Square(4);

    Console.WriteLine("RECTANGLE");
    Console.WriteLine($"Area : {r.GetArea()} Perimeter : {r.GetPerimeter()}");

    Console.WriteLine("SQUARE");
    Console.WriteLine($"Area : {s.GetArea()} Perimeter : {s.GetPerimeter()}");
  }
}