/*
Write an expression that checks for given 
*point (x, y) if it is within the circle K( (1,1), 3) 
*and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/
using System;
class CheckPointCircleRectangle
{
    static void Main()
    {
        Console.WriteLine(@"Please enter xCordinate.");
    	int pointX = int.Parse(Console.ReadLine());
        Console.WriteLine(@"Please enter yCordinate.");
    	int pointY = int.Parse(Console.ReadLine());
        int pointXforCircle = Math.Abs(pointX - 1);
        int pointYforCircle = Math.Abs(pointY - 1);
        bool inRecrangle = false;
        bool inCircle = false;
        if (Math.Sqrt((pointXforCircle) * (pointXforCircle) + (pointYforCircle) * (pointYforCircle)) <= 3)
        {
            inCircle = true;
        }
        if( pointX >= -1 && pointX <= 5 && pointY <= 1 && pointY >= -1 )
        {
            inRecrangle = true;
        }
        if ( inCircle && !inRecrangle)
        {
            Console.WriteLine("The point is in the circle, but not in the rectangle");
        }
        else if (inRecrangle)
        {
            Console.WriteLine("The point is in the Rectangle");
        }
        else if (inCircle)
        {
            Console.WriteLine("The point is in the Circle");
        }
        else if (inCircle && inRecrangle)
        {
            Console.WriteLine("The point is in the Circle and in the Rectangle");
        }
        else
        {
            Console.WriteLine("The point is NOT in the circle and NOT in the rectangle");
        }
    Console.Write("Press any key to continue . . . ");
	Console.ReadKey(true);
    }
}
