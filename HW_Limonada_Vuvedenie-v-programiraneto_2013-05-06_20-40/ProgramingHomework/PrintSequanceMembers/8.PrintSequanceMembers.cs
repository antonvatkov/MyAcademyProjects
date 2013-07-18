/*
*Create a console application that calculates and prints the square of the number 12345.
*/
using System;
class PrintSequanceMembers
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    	Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
    }
}