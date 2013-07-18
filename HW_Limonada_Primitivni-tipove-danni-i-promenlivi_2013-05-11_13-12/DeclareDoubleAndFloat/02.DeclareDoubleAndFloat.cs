/*
*Which of the following values can be assigned to a variable of type float 
*and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
*/
using System;
class DeclareDoubleAndFloat
{
	static void Main()
	{
	    double varDouble = 34.567839023;
	    float varFloat = 12.345f;
	    double varDouble1 = 8923.1234857;
	    float varFloat1 = 3456.091f;
		Console.WriteLine(" {0} {1} {2} {3}",varDouble,varFloat,
                         varDouble1,varFloat1);
	    Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}