/*
 * Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
 */
using System;
class CheckPointCircle
{
    static void Main()
    {
    	int circleRadius = 5;
        Console.WriteLine("Please enter a xCordinate rectangle");
    	int pointX = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a yCordinate rectangle");
        int pointY = int.Parse(Console.ReadLine());
        double disFormPointToCenter = Math.Sqrt(pointX * pointX + pointY * pointY);
        if (circleRadius >= disFormPointToCenter)
        {
            Console.WriteLine("The point is in the circle");
        }
        else
        {
            Console.WriteLine("The point is NOT in the circle");
        }
    Console.Write("Press any key to continue . . . ");
	Console.ReadKey(true);
    }
}
