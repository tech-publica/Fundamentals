using System;
public struct Point 
{
  public readonly double x;
  public readonly double y;

  double Distance (Point other) 
  {
      return Math.Sqrt(( x - other.x)*(x - other.x) + (y - other.y)*(y - other.y) );
  }
}