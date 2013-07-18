/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 12/2/2012
 * Time: 7:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace swichTypeVariables
{
	class swichTypeVariables
{
    static void Main()
    {
        Console.Write("Write a\n \"0\" for INT \n \"1\" for DOUBLE \n \"2\" for STRING:");
        int variable = int.Parse(Console.ReadLine());
        switch (variable)
        {
            case 0:
                Console.Write("Write a Int Variable :");
                int variableInteger = int.Parse(Console.ReadLine());
                Console.WriteLine("Int Variable + 1 : {0}",variableInteger+1);
                break;
            case 1 :
                Console.Write("Write a Double Variable :");
                double variableDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Double Variable + 1 : {0} ", variableDouble + 1);
                break;
            case 2 :
                Console.Write("Write a String Variable :");
                string variableString = (Console.ReadLine());
                Console.WriteLine("String Variable + * : {0}", variableString + "*");
                break;
        }
                Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}