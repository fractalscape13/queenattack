using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    Console.WriteLine("Please enter an X-coordinate for the Queen betweeen 1 and 8");
    string xStr = Console.ReadLine();
    int x = int.Parse(xStr);
    Console.WriteLine("Please enter a Y-coordinate for the Queen between 1 and 8");
    string yStr = Console.ReadLine();
    int y = int.Parse(yStr);
    Queen newQueen = new Queen(x, y);
    Console.WriteLine("Please enter an X-coordinate for the other piece (1-8");
    string otherXStr = Console.ReadLine();
    int otherX = int.Parse(otherXStr);
    Console.WriteLine("Please enter a Y-coordinate for the other piece (1-8");
    string otherYStr = Console.ReadLine();
    int otherY = int.Parse(otherYStr);
    newQueen.checkAttack(otherX, otherY);
  }
}
public class Queen
{
  public int xcoord;
  public int ycoord;
  public Queen(int xCoord, int yCoord)
  {
    xcoord = xCoord;
    ycoord = yCoord;
  }
  public void checkAttack(int x, int y)
  {
    int xDiff = xcoord - x;
    int yDiff = ycoord - y;
    if (x == xcoord || y == ycoord || Math.Abs(xDiff) == Math.Abs(yDiff))
    {
      Console.WriteLine("Success, the queen can attack that piece!");
    }
    else 
    {
      Console.WriteLine("The queen can't kill from this position");
    } 
  }
}