/*
*Declare two string variables and assign them with “Hello” and “World”. 
*Declare an object variable and assign it with the  
*concatenation of the first two variables (mind adding an interval). 
*Declare a third string variable and initialize it with the value of the object variable 
*(you should perform type casting). 
*/
using System;
class DeclareMultiVariable
{	
	static void Main()
	{
	    string partOne = "Hello ";
	    string partSecond = "World";
	    object unitedStringTypeObject = partOne + partSecond;
	    string onePlusSecondAsString = (string)unitedStringTypeObject;
	    Console.WriteLine(onePlusSecondAsString);
	    Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}