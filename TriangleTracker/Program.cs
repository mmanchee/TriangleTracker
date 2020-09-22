using System;
using TriangleTracker.Model;

namespace TriangleTracker {

  public class Program
    {
    public static void Main()
    {
      Console.WriteLine("Enter the first side of the triangle: ");
      string stringSideA = Console.ReadLine();
      int sideA = int.Parse(stringSideA);

      Console.WriteLine("Enter the second side of the triangle: ");
      string stringSideB = Console.ReadLine();
      int sideB = int.Parse(stringSideB);

      Console.WriteLine("Enter the final side of the triangle: ");
      string stringSideC = Console.ReadLine();
      int sideC = int.Parse(stringSideC);

      Triangle newTriangle = new Triangle();

      string result = newTriangle.IsTriangle(sideA,sideB,sideC);

      Console.WriteLine(result);
    }
  }
}