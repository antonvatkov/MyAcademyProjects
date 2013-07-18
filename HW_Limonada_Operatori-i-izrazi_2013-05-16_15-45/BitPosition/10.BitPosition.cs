/*Write a boolean expression that returns if the bit at 
 * position p (counting from 0) in a given 
 * integer number v has value of 1. Example: v=5; p=1  false.
 */
using System;
class BitPosition
{
    static void Main()
    {
        int position = 4;
        int bitType = 1;
        Console.WriteLine(@"Please enter number V.");
        int numberV= int.Parse(Console.ReadLine());
        bool isGivenBit = false;
        int newNumber = (numberV >> position) & 1;
        if (newNumber == bitType)
        {
            isGivenBit = true;
        }
        Console.WriteLine("The bit on position {0} is {1} : {2}", position, bitType, isGivenBit);
    	Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
    }
}
