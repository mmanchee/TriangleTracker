using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Model;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests{
    [TestMethod]
    public void IsTriangle_IsNotATriangle_NotATriangle(){
    
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Not A Triangle", testTriangle.IsTriangle(3,3,7));
    }
    [TestMethod]
    public void IsTriangle_IsEquilateral_Equilateral(){
    
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Equilateral", testTriangle.IsTriangle(5,5,5));
    }
    [TestMethod]
    public void IsTriangle_IsIsosceles_Isosceles(){
    
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Isosceles", testTriangle.IsTriangle(5,4,5));
    }
    [TestMethod]
    public void IsTriangle_IsScalene_Scalene(){
    
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Scalene", testTriangle.IsTriangle(3,4,5));
    }
  }
}