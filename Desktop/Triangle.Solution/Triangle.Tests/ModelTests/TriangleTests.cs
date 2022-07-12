using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Models;

namespace Triangle.Tests
  {
    [TestClass]
    public class TriangleTests
    {
      
      [TestMethod]
      public void IsTriangle_IsNotATriangle_NotATriangle()
      {
        CheckType testTriangle = new CheckType();
        Assert.AreEqual("Not a triangle", testTriangle.IsTriangle(3,9,22));
      }

      [TestMethod]
      public void IsTriangle_IsScalene_Scalene()
      {
        CheckType testTriangle = new CheckType();
        Assert.AreEqual("Scalene", testTriangle.IsTriangle(2,3,4));
      }

      [TestMethod]
      public void IsTriangle_IsEquilateral_Equilateral()
      {
        CheckType testTriangle = new CheckType();
        Assert.AreEqual("Equilateral", testTriangle.IsTriangle(5,5,5));
      }

      [TestMethod]
      public void IsTriangle_IsIsosceles_Isosceles()
      {
        CheckType testTriangle = new CheckType();
        Assert.AreEqual("Isosceles", testTriangle.IsTriangle(8,8,5));
      }
    }
  }