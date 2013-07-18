/*
 * Created by SharpDevelop.
 * User: Workstation
 * Date: 11/29/2012
 * Time: 1:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BiggestNumber
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a integer.");
			string myIntegerString = Console.ReadLine();
			int myInteger= int.Parse(myIntegerString );
			
			Console.WriteLine("Please enter a integer.");
			string myIntegerString2 = Console.ReadLine();
			int myInteger2= int.Parse(myIntegerString2 );
			
			Console.WriteLine("Please enter a integer.");
			string myIntegerString3 = Console.ReadLine();
			int myInteger3= int.Parse(myIntegerString3 );
			
			if ((myInteger>myInteger2)&&(myInteger>myInteger3))
			{
				Console.WriteLine(myInteger);
			}
			if ((myInteger2>myInteger3)&&(myInteger2>myInteger))
			{
				Console.WriteLine(myInteger2);
			}
			if ((myInteger3>myInteger)&&(myInteger3>myInteger2))
			{
				Console.WriteLine(myInteger3);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}