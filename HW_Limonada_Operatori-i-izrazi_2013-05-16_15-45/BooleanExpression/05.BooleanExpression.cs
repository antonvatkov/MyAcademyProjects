/*
 * Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
 */
using System;
class BooleanExpression
{
    static void Main()
    {
    	Console.WriteLine("Please enter a number.");
    	int number = int.Parse(Console.ReadLine());
        number = number >> 3;
        int mask = 1;
        int maskAndNumber = number & mask;
        if (maskAndNumber == 1)
        {
            Console.WriteLine("The bit on position 3 is 1");
        }
        else
        {
            Console.WriteLine("The bit on position 3 is 0");
        }
    Console.Write("Press any key to continue . . . ");
	Console.ReadKey(true);
    }
}