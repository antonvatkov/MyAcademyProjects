/*
*Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:
(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true.
*/
using System;
class ComparisonPresision //1^-6
{
    static void Main()
    {
        decimal firstVarNumber = 1235.6666666666666666666666666M;
        decimal secondVarNumber = 6.01M;
        decimal roundedVarOne = Math.Round(firstVarNumber, 6);
        Console.WriteLine(roundedVarOne);
        decimal roundedVarTwo = Math.Round(secondVarNumber, 6);
        if (roundedVarOne == roundedVarTwo)
        {
            Console.WriteLine("The numbers are equal!");
        }
        else if (roundedVarOne > roundedVarTwo)
        {
            Console.WriteLine("The first number is greater than the second!");
        }
        else
        {
            Console.WriteLine("The second number is greater than the first!");
        }
    	Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
    }
}
