/*
*Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/
using System;
class TrapezoidArea
{
    static void Main()
    {
    Console.WriteLine(@"Please enter a side a.");
    int sideA = int.Parse(Console.ReadLine());
    Console.WriteLine(@"Please enter a side b.");
	int sideB = int.Parse(Console.ReadLine());
    Console.WriteLine(@"Please enter a side height.");
	int height = int.Parse(Console.ReadLine());
    int area = ((sideA + sideB) * height) / 2;
    Console.WriteLine("The area of the trapezoid is: {0}", area);
	Console.Write("Press any key to continue . . . ");
	Console.ReadKey(true);
    }
}