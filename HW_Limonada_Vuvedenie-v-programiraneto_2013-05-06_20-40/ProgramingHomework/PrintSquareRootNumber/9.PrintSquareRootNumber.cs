/*
*Create a console application that calculates and prints the square of the number 12345.
*/
using System;
class PrintSquareRootNumber
{
	static void Main()
	{
	    Console.WriteLine("The square of 12345 is:");
	    Console.WriteLine(Math.Pow(12345,2));
	    Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
