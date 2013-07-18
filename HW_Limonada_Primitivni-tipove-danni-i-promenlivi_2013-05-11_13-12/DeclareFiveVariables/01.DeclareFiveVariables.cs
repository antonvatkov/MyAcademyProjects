/*
*Declare five variables choosing for each of them the most appropriate 
*of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent 
*the following values: 52130, -115, 4825932, 97, -10000.
*/
using System;

class SimpleDeclaration
{
    static void Main()
    {
        ushort varUshort = 52130;
        sbyte varSbyte = -115;
        int varInt = 4825932;
        byte varByte = 97;
        short varShort = -10000;
        Console.WriteLine(" {0} {1} {2} {3} {4}",varUshort,varSbyte,
                         varInt,varByte,varShort);
        Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
    }
}
