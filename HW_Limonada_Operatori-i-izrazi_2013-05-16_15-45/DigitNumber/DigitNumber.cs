/*
 * Write an expression that checks for given integer if its third 
 * digit (right-to-left) is 7. E. g. 1732  true.
 */

using System;

class TheThirdDigit
{
    static void Main()
    {
    	Console.WriteLine("Please enter a number.");
    	int number = int.Parse(Console.ReadLine());
        number = number % 100;
        int thirdDigit = number % 10;
        bool digit=false;
        Console.WriteLine(thirdDigit);
        if(thirdDigit == 7)
        {
            digit=true;
        	Console.WriteLine(digit);
        }
        else
        {
            Console.WriteLine(digit);
        }
	Console.Write("Press any key to continue . . . ");
	Console.ReadKey(true);
    }
}
