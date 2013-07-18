/*
*Declare a character variable and assign it with the symbol that has Unicode code 72. 
*Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
*Use Windows Calculator to find its hexadecimal representation.
*/
using System;
class DeclareCharacterVariable
{
    static void Main()
    {
        char symbol = '\u0048';
        Console.WriteLine(symbol);
    	Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
    }
}