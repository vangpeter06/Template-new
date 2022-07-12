using System;
using System.Collections.Generic;
using Triangle.Models;

namespace TriangleUi
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Make a triangle");
      Console.WriteLine("Please enter side 1");
      int side1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Make a triangle");
      Console.WriteLine("Please enter side 2");
      int side2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Make a triangle");
      Console.WriteLine("Please enter side 3");
      int side3 = int.Parse(Console.ReadLine());
      
      CheckType inputTriangle = new CheckType();
      string result = inputTriangle.IsTriangle(side1, side2, side3);
      Console.WriteLine(result);
    }
  }
}