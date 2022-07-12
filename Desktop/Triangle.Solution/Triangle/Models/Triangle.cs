using System;

namespace Triangle.Models
  {
    public class CheckType
    {
      public string IsTriangle(int side1, int side2, int side3)
      {
        if ((side1 > (side2 + side3)) || (side2 > (side1 + side3)) || (side3 > (side1 + side2)))
        { 
          return "Not a triangle";
        }  
        else if ((side1 != side2) && ((side1 != side3)) && ((side2 != side3)))
        {
          return "Scalene";
        }
        else if ((side1 == side2) && (side1 == side3))
        {
          return "Equilateral";
        }
        else
        {
          return "Isosceles";
        }
      }
    }
  }
  
  