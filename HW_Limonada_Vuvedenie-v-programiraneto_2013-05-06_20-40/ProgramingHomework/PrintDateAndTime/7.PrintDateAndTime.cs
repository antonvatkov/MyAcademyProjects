/*
*Create a console application that prints the current date and time.
*/
using System;
class PrintDateAndTime
{
	public static void Main()
	{
		Console.WriteLine("The date and time are:");
        Console.WriteLine(DateTime.Now);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
