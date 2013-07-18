/*
*Write a program that reads two positive integer numbers 
*and prints how many numbers p exist between them such that 
*the reminder of the division by 5 is 0 (inclusive).
*Example: p(17,25) = 2.
*/
using System;
class PrintsNumbersInRange
{
	public static void Main()
	{
		Console.WriteLine("Please enter the start number:");
        int startNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the end number:");
        int endNumber = int.Parse(Console.ReadLine());
		int count =0;
		for (int i = startNumber; i < endNumber; i++) 
		{
			if ((i%5)==0)
			{
			 count++;	
			}
		}
		Console.WriteLine("p({0},{1})={2}",startNumber,endNumber,count);
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
