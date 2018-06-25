using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    Triangle triangleOne = new Triangle();
    triangleOne.CreateTriangle();

  }
}

class Triangle
{
  private int _sideA;
  private int _sideB;
  private int _sideC;

  public Triangle(int sideA = 1, int sideB = 1, int sideC = 1)
  {
    _sideA = sideA;
    _sideB = sideB;
    _sideC = sideC;
  }

  public void CreateTriangle()
  {
    Console.WriteLine("Side A: ");
    _sideA = int.Parse(Console.ReadLine());
    Console.WriteLine("Side B: ");
    _sideB = int.Parse(Console.ReadLine());
    Console.WriteLine("Side C: ");
    _sideC = int.Parse(Console.ReadLine());
    Console.WriteLine(GetTriangleType());
  }

  private string GetTriangleType()
  {
    string triangleType = "Not a Triangle";
    bool aEqualsB = _sideA == _sideB;
    bool aEqualsC = _sideA == _sideC;
    bool bEqualsC = _sideB == _sideC;
    bool isTriangle = !(_sideA+_sideB < _sideC || _sideA+_sideC < _sideB || _sideB+_sideC < _sideA);
    // Side A == Side B != Side C
    // Side A != Side B == Side C
    // Side C == Side A != Side B

    if(isTriangle)
    {
      if(aEqualsB && aEqualsC)
      {
        triangleType = "Equilateral";
      }
      else if ((aEqualsB && !bEqualsC) || (!aEqualsB && bEqualsC)|| (aEqualsC && !aEqualsB))
      {
        triangleType = "Isosceles";
      }
      else
      {
        triangleType = "Scalene";
      }
    }
    return triangleType;
  }
}
