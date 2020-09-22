using System;

namespace TriangleTracker.Model
{
  public class Triangle
  {
    public string IsTriangle (int sideA, int sideB, int sideC)
    {
      if(sideA >= (sideB+sideC) || sideB >= (sideA + sideB)|| sideC >= (sideA+sideB))
      {
        return "Not A Triangle";
      }
      else if (sideA ==sideB && sideB==sideC){
        return "Equilateral";
      }
      else if (sideA == sideB && sideA != sideC || sideB == sideC && sideB != sideA || sideC == sideA && sideC != sideB){
        return "Isosceles";
      }
      else
      {
        return "Scalene";
      }
    }
  }
}