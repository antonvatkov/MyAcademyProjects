/*
*Declare two string variables and assign them with following value:
*Do the above in two different ways: with and without using quoted strings.
 */
using System;
class QuoteSolution
{
    static void Main()
    {
        Console.WriteLine("The \"use\" of quotations causes difficulties.");
        Console.WriteLine(@"The ""use"" of quotations causes difficulties.");
    	Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
    }
}