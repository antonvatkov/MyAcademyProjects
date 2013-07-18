/*
*Familiarize yourself with:
*Microsoft Visual Studio
*Microsoft Developer Network (MSDN) Library Documentation
*Find information about Console.WriteLine() method.
*/
using System;
class Msmd
{
	public static void Main()
	{
		Console.Beep();
		Console.WriteLine("Hello World!");
		Console.Beep(1,3);
		/*
		 * http://msdn.microsoft.com/library/default.aspx
		*/
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}
